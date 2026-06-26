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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window10.xaml
    /// </summary>
    public partial class Window10 : Window
    {
        private int state = 0;
        private DispatcherTimer timer;
        public Window10()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            UpdateLights();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            state = (state + 1) % 3;
            UpdateLights();
        }
        private void UpdateLights()
        {
            RedLight.Fill = Brushes.DarkRed;
            YellowLight.Fill = Brushes.Olive;
            GreenLight.Fill = Brushes.DarkGreen;
            switch (state)
            {
                case 0:
                    RedLight.Fill = Brushes.Red; break;
                case 1:
                    YellowLight.Fill = Brushes.Yellow; break;
                case 2:
                    GreenLight.Fill = Brushes.Lime; break;
            }
        }
    }
}
