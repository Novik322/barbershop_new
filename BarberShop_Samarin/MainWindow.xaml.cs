using BarberShop_Samarin.AppData;
using BarberShop_Samarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppConnect.project_model = new SamarinR_BarbershopEntities();
            AppFrame.Main = MainFrame;
            MainFrame.Navigate(new AuthPage());
            OnepageBtn.Visibility = Visibility.Hidden;
            BronBtn.Visibility = Visibility.Hidden;
            ClientsBtn.Visibility = Visibility.Hidden;
            ExtRegBtn.Visibility = Visibility.Hidden;



        }

        private void WindowMenuGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

            if (e.ClickCount > 1)
            {
                if (Application.Current.MainWindow.WindowState == WindowState.Normal)
                {
                    Application.Current.MainWindow.WindowState = WindowState.Maximized;
                }
                else
                {
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                }
            }

        }

        private void CloseAppBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MaximizeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState == WindowState.Normal)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }

        private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void RegistationBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AuthPage());
        }

        private void BronBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new BronPage());
        }

        private void ClientsBtn_Click(object sender, RoutedEventArgs e)

        {
            MainFrame.Navigate(new ClinentsPage());
        }

        private void OnepageBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new WelcomePage());
        }

        private void ExtRegBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AuthPage());
            OnepageBtn.Visibility = Visibility.Hidden;
            BronBtn.Visibility = Visibility.Hidden;
            ClientsBtn.Visibility = Visibility.Hidden;
            ExtRegBtn.Visibility = Visibility.Hidden;
            RegistationBtn.Visibility = Visibility.Visible;
        }
    }
}
