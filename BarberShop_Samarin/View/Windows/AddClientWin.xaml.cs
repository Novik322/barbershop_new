using BarberShop_Samarin.AppData;
using BarberShop_Samarin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
using System.Windows.Shapes;

namespace BarberShop_Samarin.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddClientWin.xaml
    /// </summary>
    public partial class AddClientWin : Window
    {
        private Clients clients;
        public AddClientWin(Clients client)
        {
            InitializeComponent();
            AddClientWindow.DataContext = client;
            clients = client;
        }

        private void AddClientBtn_Click(object sender, RoutedEventArgs e)
        {
            Added();
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Added()
        {
            Model.Clients clients = new Model.Clients();
            if (string.IsNullOrEmpty(NumCardTb.Text) && (string.IsNullOrEmpty(NameCliTb.Text)) && (string.IsNullOrEmpty(TelTb.Text)))
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                clients.Name = NameCliTb.Text;
                clients.Phone = TelTb.Text;
                AppConnect.project_model.Clients.Add(clients);
                AppConnect.project_model.SaveChanges();
                this.Close();
                MessageBox.Show("Данные обновлены!");
            }
        }
    }
}
