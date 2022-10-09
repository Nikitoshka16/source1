using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intercop = Microsoft.Office.Interop;

namespace PP
{
    class Word
    {
        private FileInfo _fileInfo;

        public Word(string fileName)
        {
            fileName = @"C:\Users\User\source\repos\PP\PP\письмо.docx";

            if (File.Exists(fileName))
            {
                _fileInfo = new FileInfo(fileName);
            }
            else
            {
                MessageBox.Show("Подождите", "");


            }
        }

        internal bool Process(Dictionary<string, string> items)
        {
            Intercop.Word.Application app = null;
            try
            {
                app = new Intercop.Word.Application();
                Object file = _fileInfo.FullName;
                Object missing = Type.Missing;
                app.Documents.Open(file);
                foreach (var item in items)
                {
                    Intercop.Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;
                    Object wrap = Intercop.Word.WdFindWrap.wdFindContinue;
                    Object replace = Intercop.Word.WdReplace.wdReplaceAll;
                    find.Execute
                        (
                        FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: false,
                        MatchAllWordForms: false,
                        Forward: false,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace);
                }
                Object newFileName = Path.Combine(_fileInfo.DirectoryName, DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss") + " " + _fileInfo.Name);
                app.ActiveDocument.SaveAs(newFileName);
                app.ActiveDocument.Close();
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                if (app != null)
                    app.Quit();
            }
            return false;
        }
    }
}
