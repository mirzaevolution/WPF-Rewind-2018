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

namespace ScrollViewerRewind
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

        private void RepeateButtonLineUpOnClick(object sender, RoutedEventArgs e)
        {
            scrollViewerTest.LineUp();
        }
        private void RepeateButtonLineDownOnClick(object sender, RoutedEventArgs e)
        {
            scrollViewerTest.LineDown();
        }

        private void RepeateButtonLineLeftOnClick(object sender, RoutedEventArgs e)
        {
            scrollViewerTest.LineLeft();
        }

        private void RepeateButtonLineRightOnClick(object sender, RoutedEventArgs e)
        {
            scrollViewerTest.LineRight();
        }

        private void RepeateButtonPageUp(object sender, RoutedEventArgs e)
        {
            scrollViewerTest.PageUp();
        }

        private void RepeateButtonPageDown(object sender, RoutedEventArgs e)
        {
            scrollViewerTest.PageDown();
            
            
        }

        private void RepeateButtonPageLeft(object sender, RoutedEventArgs e)
        {
            scrollViewerTest.PageLeft();
        }

        private void RepeateButtonPageRight(object sender, RoutedEventArgs e)
        {
            
            scrollViewerTest.PageRight();

        }

       

        private void RepeateButtonScrollTopOnClick(object sender, RoutedEventArgs e)
        {
            scrollViewerTest.ScrollToTop();
        }

        private void RepeateButtonScrollBottomOnClick(object sender, RoutedEventArgs e)
        {
            scrollViewerTest.ScrollToBottom();
        }

        private void RepeateButtonScrollLeftOnClick(object sender, RoutedEventArgs e)
        {
            scrollViewerTest.ScrollToLeftEnd();
        }

        private void RepeateButtonScrollRightOnClick(object sender, RoutedEventArgs e)
        {
            scrollViewerTest.ScrollToRightEnd();
            
        }
        private void RepeateButtonScrollToHomeOnClick(object sender, RoutedEventArgs e)
        {
            scrollViewerTest.ScrollToHome();
        }
        private void RepeateButtonScrollToEndOnClick(object sender, RoutedEventArgs e)
        {
            scrollViewerTest.ScrollToEnd();
        }
    }
}
