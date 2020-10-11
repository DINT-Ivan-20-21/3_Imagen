using System;
using System.Windows;
using System.Windows.Controls;

namespace _3_Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void opacidad_Checked(object sender, RoutedEventArgs e)
        {
            double opacity = double.Parse((sender as RadioButton).Tag.ToString(), System.Globalization.CultureInfo.InvariantCulture);
            modificarImage.Opacity = opacity;
        }

        private void ajuste_Checked(object sender, RoutedEventArgs e)
        {
            modificarImage.Stretch = (System.Windows.Media.Stretch)Enum.Parse(typeof(System.Windows.Media.Stretch), (sender as RadioButton).Tag.ToString());
        }
    }
}
