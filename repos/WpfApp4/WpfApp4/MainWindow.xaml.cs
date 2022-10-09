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
using WpfApp4.DataModel;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        auto2Entities BD = new auto2Entities();
        public MainWindow()
        {

            InitializeComponent();
            combobind();
            
            using(codefirst context= new codefirst())
            {
                //Dolj dolj = new Dolj();
                //dolj.doljID = 1;
                //dolj.obiz = "Ахрана";
                //dolj.zp = 50;
                //dolj.nal = "есть";
                


                Sotr sotr = new Sotr();
                sotr.sotrID = 1;
                sotr.name = "Игорь";
                sotr.family = "Палка";
                sotr.otch = "Висарионович";
                sotr.rojd = 1970;
                sotr.pas = "1010101010";
                sotr.doljID = 1;

                //context.Doljs.Add(dolj);
                context.Sotrs.Add(sotr);
                context.SaveChanges();

            }
        }
        public List<Doljs> doljs { get; set; }

        private void cbP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mda.ItemsSource = BD.Doljs.Where(x => x.doljID == cbP.SelectedIndex + 1).ToList();
        }

        private void combobind()
        {
            auto2Entities BD = new auto2Entities();
            var item = BD.Doljs.ToList();
            doljs = item;
            DataContext = doljs;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            mda.ItemsSource = BD.Doljs.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Doljs doljJ = new Doljs();
            doljJ.obiz = tbObiz.Text;
            doljJ.zp = Convert.ToInt32(tbZp.Text);
            doljJ.nal = tbNal.Text;
            BD.Doljs.Add(doljJ);
            BD.SaveChanges();
            mda.ItemsSource = BD.Doljs.ToList();
        }


    }
}
