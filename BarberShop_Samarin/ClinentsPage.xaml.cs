using BarberShop_Samarin.AppData;
using BarberShop_Samarin.Model;
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

namespace BarberShop_Samarin
{
    /// <summary>
    /// Логика взаимодействия для ClinentsPage.xaml
    /// </summary>
    public partial class ClinentsPage : Page
    {
        public ClinentsPage()
        {
            InitializeComponent();
        }

        private void ClientsLb_Initialized(object sender, EventArgs e)
        {
        }

        private void ClientsLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            AppData.ClientBuilder clients = new AppData.ClientBuilder();
            ClientsDg.ItemsSource = clients.GetMaterials();
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

        }

        private void DelClientBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditClientBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
