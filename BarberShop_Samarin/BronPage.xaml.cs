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
    /// Логика взаимодействия для BronPage.xaml
    /// </summary>
    public partial class BronPage : Page
    {
        Records records = new Records();
        public BronPage()
        {
            InitializeComponent();
            NameCliTb.IsEnabled = false;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddBronBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NumCardTb.Text))
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                //records.ID = NumCardTb.Text();
                records.ID = Convert.ToInt32(this.NumCardTb.Text);
                records.Client = Convert.ToInt32(this.NameCliTb.Text);
                records.Master = Convert.ToInt32(this.MasterCmb.Text);


                AppConnect.project_model.Records.Add(records);
                AppConnect.project_model.SaveChanges();
                MessageBox.Show("Данные добавлены!");
            }
        }
    }
}
