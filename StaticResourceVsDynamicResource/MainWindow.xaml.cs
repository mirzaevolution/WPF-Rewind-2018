using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StaticResourceVsDynamicResource
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

        private void ButtonStaticClickHandler(object sender, RoutedEventArgs e)
        {
            if (TryFindResource("Rectangle1Fill") is SolidColorBrush brush)
            {
                brush = new SolidColorBrush(Colors.Yellow);
            }
            //Resources["Rectangle1Fill"] = new SolidColorBrush(Colors.Yellow);
        }

        private void ButtonDynClickHandler(object sender, RoutedEventArgs e)
        {
            //if (TryFindResource("Rectangle2Fill") is SolidColorBrush brush)
            //{
            //    brush.Color = Colors.Black;
            //}
            Resources["Rectangle2Fill"] = new SolidColorBrush(Colors.Black);

        }
    }
}
