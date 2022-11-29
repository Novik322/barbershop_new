using BarberShop_Samarin.AppData;
using BarberShop_Samarin.View.Pages;
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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void Enter()
        {
            try
            {
                var user = AppConnect.project_model.Admins.FirstOrDefault(i => i.Login == LoginTb.Text && i.Password == PassTb.Text);
                if (user == null)
                {
                    MessageBox.Show("Данного пользователя не существует!", "Ошибка при авторизации!",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    (Application.Current.MainWindow as MainWindow).BronBtn.Visibility = Visibility.Visible;
                    (Application.Current.MainWindow as MainWindow).ClientsBtn.Visibility = Visibility.Visible;
                    (Application.Current.MainWindow as MainWindow).OnepageBtn.Visibility = Visibility.Visible;
                    (Application.Current.MainWindow as MainWindow).RegistationBtn.Visibility = Visibility.Hidden;
                    (Application.Current.MainWindow as MainWindow).ExtRegBtn.Visibility = Visibility.Visible;
                    switch (user.Dostup)
                    {
                        case 1:
                            AppFrame.Main.Navigate(new WelcomePage());
                            break;
                        case 2:
                            AppFrame.Main.Navigate(new WelcomePage());
                            break;
                        case 3:
                            MessageBox.Show("Данные не обнаружены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                            break;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка" + Ex.Message.ToString() + "Критическая работа приложения!",
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            Enter();
        }
    }
}
