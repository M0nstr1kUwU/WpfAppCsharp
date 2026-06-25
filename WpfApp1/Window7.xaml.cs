using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

        private void FileTextBox_TextChanged(object sender, TextChangedEventArgs e) { }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Выберите текстовый файл",
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };

            if (dialog.ShowDialog() != true)
                return;

            try
            {
                string text = File.ReadAllText(dialog.FileName, Encoding.UTF8);

                FileTextBox.Text = text;
                FileNameText.Text = System.IO.Path.GetFileName(dialog.FileName);
                StatusText.Text = $"Файл успешно прочитан. Символов: {text.Length}";
            }
            catch (UnauthorizedAccessException)
            {
                StatusText.Text = "Нет доступа к выбранному файлу.";
            }
            catch (IOException)
            {
                StatusText.Text = "Не удалось прочитать файл.";
            }
            catch (Exception ex)
            {
                StatusText.Text = $"Ошибка: {ex.Message}";
            }
        }
    }
}
