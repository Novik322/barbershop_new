using BarberShop_Samarin.AppData;
using BarberShop_Samarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BarberShop_Samarin.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditClientWin.xaml
    /// </summary>
    public partial class EditClientWin : Window
    {
        private Clients clients;
        public EditClientWin(Clients client)
        {
            InitializeComponent();
            EditClientWindow.DataContext = client;
            clients = client;
        }

        private void EditClientBtn_Click(object sender, RoutedEventArgs e)
        {
            Changed();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Changed()
        {
            
            if (string.IsNullOrEmpty(NumCardTb.Text) && (string.IsNullOrEmpty(NameCliTb.Text)) && (string.IsNullOrEmpty(TelTb.Text)))
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                clients.ID = Convert.ToInt32(NumCardTb.Text);
                clients.Name = NameCliTb.Text.ToString();
                clients.Phone = TelTb.Text.ToString();

                AppConnect.project_model.SaveChanges();
                this.Close();
                MessageBox.Show("Данные обновлены!");
            }
        }
    }
}
