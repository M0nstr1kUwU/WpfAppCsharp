using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        private double fNum;
        private string operation;
        public Window5()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Display.Text += btn.Content.ToString();
        }

        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            fNum = Convert.ToDouble(Display.Text);
            operation = btn.Content.ToString();
            Display.Clear();
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            double sNum = Convert.ToDouble(Display.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = fNum + sNum;
                    break;

                case "-":
                    result = fNum - sNum;
                    break;

                case "*":
                    result = fNum * sNum;
                    break;

                case "/":
                    result = fNum / sNum;
                    break;
            }

            Display.Text = result.ToString();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Display.Clear();
            fNum = 0;
            operation = "";
        }
    }
}
