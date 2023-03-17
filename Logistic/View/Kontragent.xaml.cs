using Logistic.Model;
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

namespace Logistic.View
{
    /// <summary>
    /// Логика взаимодействия для Kontragent.xaml
    /// </summary>
    public partial class Kontragent : Page
    {
      //  ApplicationContext db;
        static int count = 0;
        public Kontragent()
        {
            InitializeComponent();
            Name.ToolTip = "Обязательное поле для заполнения";
            INN.ToolTip = "Обязательное поле для заполнения";
            Adress.ToolTip = "Обязательное поле для заполнения";
          //  db = new ApplicationContext();

        }

        private void Button_new_agent(object sender, RoutedEventArgs e)
        {
            Agent agent = new Agent();
            agent.id = ++count;
            int n; 
            bool name = false, inn = false, kpp = false, adr = false, ml = false;

            if (Name.Text.Length < 3)
            {
                Name.ToolTip = "Неккоректное заполнение";
                Name.Background = Brushes.Red;

            }
            else
            {
                Name.ToolTip = "";
                Name.Background = Brushes.Transparent;
                agent.Name = Name.Text.Trim();
                name = true;
            }

            if (INN.Text.Length < 1 || !int.TryParse(INN.Text, out n))
            {
                INN.ToolTip = "Неккоректное заполнение";
                INN.Background = Brushes.Red;
            }
            else
            {
                INN.ToolTip = "";
                INN.Background = Brushes.Transparent;
                agent.INN = int.Parse(INN.Text.Trim());
                inn = true;
            }


            if (KPP.Text.Length != 0)
            {
                if (!int.TryParse(KPP.Text, out n))
                {
                    KPP.ToolTip = "Неккоректное заполнение";
                    KPP.Background = Brushes.Red;
                }
                else
                {
                    KPP.ToolTip = "";
                    KPP.Background = Brushes.Transparent;
                    agent.KPP = int.Parse(KPP.Text.Trim());
                    kpp= true;
                }
            }
            else
            {
                KPP.ToolTip = "";
                KPP.Background = Brushes.Transparent;
                kpp = true;
            }

            if (Adress.Text.Length < 1 || Adress == null)
            {
                Adress.ToolTip = "Неккоректное заполнение";
                Adress.Background = Brushes.Red;
            }
            else
            {
                Adress.ToolTip = "";
                Adress.Background = Brushes.Transparent;
                agent.Adress = Adress.Text.Trim();
                adr = true;
            }

            if (Phone != null)
            {
                agent.Phone = Phone.Text.Trim().ToUpper();
            }

            if (Email.Text.Length != 0)
            {
                if (!Email.Text.Contains("@") || !Email.Text.Contains("."))
                {
                    Email.ToolTip = "Неккоректное заполнение";
                    Email.Background = Brushes.Red;
                }
                else
                {
                    Email.ToolTip = "";
                    Email.Background = Brushes.Transparent;
                    agent.Email = Email.Text.Trim();
                    ml = true;
                }

            }
            else
            {
                Email.ToolTip = "";
                Email.Background = Brushes.Transparent;
                ml = true;
            }

            if (name && inn && kpp && adr && ml)
            { MessageBox.Show($"Вы добавили id = {agent.id} Имя = {agent.Name} ИНН = {agent.INN}");
                Name.Clear();
                INN.Clear();
                KPP.Clear();
                Adress.Clear();
                Phone.Clear();
                Email.Clear();
            }
            else
            {
                MessageBox.Show("Чувак, что-то не так!");
            }
            // db.Agents.Add(agent);
            // db.SaveChanges();


        }
    }


}
    
