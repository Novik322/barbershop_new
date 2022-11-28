using BarberShop_Samarin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BarberShop_Samarin.AppData
{
    class UserSession
    {
        public static void CheckRegistation(TextBox name, TextBox login, PasswordBox password)
        {
            //1. sozdat object (на основе класса таблицы, куда нужно добавить запись)
            Admins user = new Admins()
            {
                Name = name.Text,
                Login = login.Text,
                Password = password.Password
            };

            //2. Нужно добавить объект в таблицу.

            AppConnect.GetContext().Admins.Add(user);

            //3. Сохранить изминения (из модели в БД)
            AppConnect.GetContext().SaveChanges();

            //4. Оповестить пользователя о добавлении его в БД(регистрации)
            MessageBox.Show("Пользователь зарегистрирован");
        }
    }
}
