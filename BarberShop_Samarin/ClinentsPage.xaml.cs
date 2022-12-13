using BarberShop_Samarin.AppData;
using BarberShop_Samarin.Model;
using BarberShop_Samarin.View.Pages;
using BarberShop_Samarin.View.Windows;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BarberShop_Samarin
{
    /// <summary>
    /// Логика взаимодействия для ClinentsPage.xaml
    /// </summary>
    public partial class ClinentsPage : Page
    {
        private Clients client;
        public ClinentsPage()
        {
            InitializeComponent();

            foreach (Clients client in AppConnect.project_model.Clients)
            {
                ClientsDg.Items.Add(client);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AppData.ClientBuilder clients = new AppData.ClientBuilder();
            //ClientsDg.ItemsSource = clients.GetMaterials();
        }

        private void SearchTb_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void SearchTb_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddClientBtn_Click(object sender, RoutedEventArgs e)
        {
            AddClientWin addClientWin = new AddClientWin(client);
            addClientWin.Show();
        }

        private void DelClientBtn_Click(object sender, RoutedEventArgs e)
        {
   

            MessageBoxResult result = MessageBox.Show("Вы точно хотите удалить эти данные?", "Внимание! Подтвердите действие!", MessageBoxButton.OKCancel, MessageBoxImage.Question);
           
            if (result == MessageBoxResult.OK)
            {
                ClientsDg.Items.Remove(client);
                AppConnect.project_model.SaveChanges();
            }
            else
            {
                return;
            }
        }

        private void EditClientBtn_Click(object sender, RoutedEventArgs e)
        {
            EditClientWin editClientWin = new EditClientWin(client);
            editClientWin.Show();
        }

        private void ClientsDg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            client = (Clients)((DataGrid)sender).SelectedItem;

        }
    }
}
