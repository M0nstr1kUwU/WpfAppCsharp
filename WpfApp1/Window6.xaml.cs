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
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        private bool editMode = false;
        public Window6()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string login = "admin";
            string password = "12345";
            if (tbLogin.Text == login && pbPassword.Password == password)
            {
                LoginGrid.Visibility = Visibility.Collapsed;
                ProfileGrid.Visibility = Visibility.Visible;

                tbFio.Text = "LEVIAFANOEB-67";
                tbPhone.Text = "+7 (978) 555-35-35";
                tbEmail.Text = "lefiafanoeb67@mail.ru";
                imgPhoto.Visibility = Visibility.Visible;
            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            editMode = true;
            tbFio.IsReadOnly = false;
            tbPhone.IsReadOnly = false;
            tbEmail.IsReadOnly = false;
            btnSave.Visibility = Visibility.Visible;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            editMode = false;

            tbFio.IsReadOnly = true;
            tbPhone.IsReadOnly = true;
            tbEmail.IsReadOnly = true;

            btnSave.Visibility = Visibility.Collapsed;

            MessageBox.Show("Данные сохранены");
        }
    }
}
