using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp3.DataModel;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (CodeFirstModel context = new CodeFirstModel())
            {
                Dolj dolj = new Dolj();
                dolj.obiz = "влад2";
                dolj.zp = 18300;
                dolj.nal = "нету";

                context.Doljs.Add(dolj);
                context.SaveChanges();
            }
        }
    }
}
