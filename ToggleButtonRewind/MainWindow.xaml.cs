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

namespace ToggleButtonRewind
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
        bool show = true;
        private void ToggleButtonMainClickHandler(object sender, RoutedEventArgs e)
        {
            if (!show)
            {
                show = true;
                ToggleButtonMain.Content = "Show Box";
                BorderBox.Visibility = Visibility.Visible;
            }
            else
            {
                show = false;
                ToggleButtonMain.Content = "Hide Box";
                BorderBox.Visibility = Visibility.Collapsed;
            }
        }
    }
}
