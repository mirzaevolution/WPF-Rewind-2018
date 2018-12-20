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

namespace BrintIntoViewMethod
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

        private void ButtonTopClickHandler(object sender, RoutedEventArgs e)
        {
            BorderTop.BringIntoView();
        }

        private void ButtonMiddleClickHandler(object sender, RoutedEventArgs e)
        {
            BorderMiddle.BringIntoView();
        }

        private void ButtonBottomClickHandler(object sender, RoutedEventArgs e)
        {
            BorderBottom.BringIntoView();
        }
    }
}
