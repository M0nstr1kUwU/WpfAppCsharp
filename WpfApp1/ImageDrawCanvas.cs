using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    public class ImageDrawCanvas : Canvas
    {
        private readonly BitmapImage image;

        public ImageDrawCanvas()
        {
            Background = new SolidColorBrush(Color.FromRgb(45, 45, 48));

            image = new BitmapImage();

            image.BeginInit();
            image.UriSource = new Uri(
                "images/user.png",
                UriKind.Absolute);

            image.CacheOption = BitmapCacheOption.OnLoad;
            image.EndInit();

            image.Freeze();
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            if (ActualWidth <= 0 || ActualHeight <= 0)
                return;
            double imageWidth = image.PixelWidth;
            double imageHeight = image.PixelHeight;
            if (imageWidth <= 0 || imageHeight <= 0)
                return;
            double scaleX = ActualWidth / imageWidth;
            double scaleY = ActualHeight / imageHeight;
            double scale = Math.Min(scaleX, scaleY);

            double width = imageWidth * scale;
            double height = imageHeight * scale;
            double x = (ActualWidth - width) / 2;
            double y = (ActualHeight - height) / 2;
            Rect destinationRectangle = new Rect(x, y, width, height);
            drawingContext.DrawImage(image, destinationRectangle);
        }
    }
}