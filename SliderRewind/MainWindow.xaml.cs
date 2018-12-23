using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SliderRewind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void DetectAndChange()
        {

            double red = SliderRed.Value;
            double green = SliderGreen.Value;
            double blue = SliderBlue.Value;
            TextRedValue.Text = $"({(int)red})";
            TextGreenValue.Text = $"({(int)green})";
            TextBlueValue.Text = $"({(int)blue})";
            
            Color color = Color.FromRgb((byte)red, (byte)green, (byte)blue);
            CanvasDrawing.Background = new SolidColorBrush(color);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DetectAndChange();
        }

        private void SliderRed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            DetectAndChange();

        }

        private void SliderGreen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            DetectAndChange();

        }

        private void SliderBlue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            DetectAndChange();

        }
    }
}
