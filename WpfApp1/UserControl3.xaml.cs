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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UserControl3.xaml
    /// </summary>
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }
        public int Rating { get; private set; }

        private void SetRating(int value)
        {
            Rating = value;
            MessageBox.Show($"Оценка: {Rating}");
        }

        private void Star1_Click(object sender, RoutedEventArgs e) { SetRating(1); }

        private void Star2_Click(object sender, RoutedEventArgs e) { SetRating(2); }

        private void Star3_Click(object sender, RoutedEventArgs e) { SetRating(3); }

        private void Star4_Click(object sender, RoutedEventArgs e) { SetRating(4); }

        private void Star5_Click(object sender, RoutedEventArgs e) { SetRating(5); }
    }
}
