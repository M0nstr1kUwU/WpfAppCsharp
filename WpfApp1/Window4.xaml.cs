using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        private string savedLogin = "";
        private string savedPassword = "";
        public Window4()
        {
            InitializeComponent();
        }
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            savedLogin = tbLogin.Text;
            savedPassword = pbPassword.Password;
            MessageBox.Show("Пользователь зарегистрирован!");
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == savedLogin && pbPassword.Password == savedPassword)
            {
                LoginPanel.Visibility = Visibility.Collapsed;
                UserPanel.Visibility = Visibility.Visible;
            }
            else
                MessageBox.Show("Неверный логин или пароль!");
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            UserPanel.Visibility = Visibility.Collapsed;
            LoginPanel.Visibility = Visibility.Visible;

            tbLogin.Clear();
            pbPassword.Clear();
        }
    }
}
