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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        private int ft = 0;
        public Window3()
        {
            InitializeComponent();
        }

        private void MainCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition(MainCanvas);

            switch (ft)
            {
                case 0:
                    Ellipse ellipse = new Ellipse
                    {
                        Width = 80,
                        Height = 50,
                        Fill = Brushes.Navy,
                        Stroke = Brushes.Moccasin,
                        StrokeThickness = 1
                    };

                    Canvas.SetLeft(ellipse, p.X);
                    Canvas.SetTop(ellipse, p.Y);
                    MainCanvas.Children.Add(ellipse);
                    break;
                case 1:
                    Rectangle square = new Rectangle
                    {
                        Width = 70,
                        Height = 70,
                        Fill = Brushes.BlueViolet,
                        Stroke = Brushes.WhiteSmoke,
                        StrokeThickness = 2
                    };

                    Canvas.SetLeft(square, p.X);
                    Canvas.SetTop(square, p.Y);
                    MainCanvas.Children.Add(square);
                    break;
                case 2:
                    Polygon pentagon = new Polygon
                    {
                        Fill = Brushes.Orange,
                        Stroke = Brushes.White,
                        StrokeThickness = 1
                    };

                    pentagon.Points = new PointCollection()
                    {
                        new Point(35,0),
                        new Point(80,45),
                        new Point(55,70),
                        new Point(25,120),
                        new Point(0,30)
                    };

                    Canvas.SetLeft(pentagon, p.X);
                    Canvas.SetTop(pentagon, p.Y);
                    MainCanvas.Children.Add(pentagon);
                    break;
            }
            ft = (ft + 1) % 3;
        }
    }
}
