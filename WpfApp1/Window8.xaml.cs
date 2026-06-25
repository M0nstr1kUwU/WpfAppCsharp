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
    /// Логика взаимодействия для Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        private BitmapImage image;

        public Window8()
        {
            InitializeComponent();
            image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("pack://application:,,,/images/user.png", UriKind.Absolute);
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.EndInit();
            image.Freeze();
        }

        private void MainCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            DrawImageOnCanvas();
        }

        private void MainCanvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            DrawImageOnCanvas();
        }

        private void DrawImageOnCanvas()
        {
            if (image == null)
                return;

            if (MainCanvas.ActualWidth <= 0 || MainCanvas.ActualHeight <= 0)
                return;

            MainCanvas.Children.Clear();

            double canvasWidth = MainCanvas.ActualWidth;
            double canvasHeight = MainCanvas.ActualHeight;

            double imageWidth = image.PixelWidth;
            double imageHeight = image.PixelHeight;

            double scaleX = canvasWidth / imageWidth;
            double scaleY = canvasHeight / imageHeight;
            double scale = Math.Min(scaleX, scaleY);

            double drawWidth = imageWidth * scale;
            double drawHeight = imageHeight * scale;
            double x = (canvasWidth - drawWidth) / 2;
            double y = (canvasHeight - drawHeight) / 2;

            DrawingGroup drawingGroup = new DrawingGroup();

            using (DrawingContext drawingContext = drawingGroup.Open())
            {
                drawingContext.DrawImage(
                    image,
                    new Rect(x, y, drawWidth, drawHeight));
            }

            Image resultImage = new Image
            {
                Source = new DrawingImage(drawingGroup),
                Width = canvasWidth,
                Height = canvasHeight,
                Stretch = Stretch.None,
                IsHitTestVisible = false
            };

            Canvas.SetLeft(resultImage, 0);
            Canvas.SetTop(resultImage, 0);

            MainCanvas.Children.Add(resultImage);
        }
    }
}
