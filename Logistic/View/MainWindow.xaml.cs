using System;
using System.Collections.Generic;
using System.Data.Common;
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

namespace Logistic.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public List<Page> list;
       
        public MainWindow()
        {
            InitializeComponent();
            this.list = new List<Page>();
            list.Add(new NewP());
            list.Add(new Kontragent());
            list.Add(new Transp());
        }
             
        private void Poisk_Click(object sender, RoutedEventArgs e)
        {

        }

        public void NewP_Click(object sender, RoutedEventArgs e)
        {
            MAIN_FRAME.Content = list[0];  //new NewP();
        }

        public void Agent_Click(object sender, RoutedEventArgs e)
        {
           MAIN_FRAME.Content = list[1];//  new Kontragent();
        }

        private void Tr_Click(object sender, RoutedEventArgs e)
        {
            MAIN_FRAME.Content = list[2];//new Transp();
            
        }
    }
}
