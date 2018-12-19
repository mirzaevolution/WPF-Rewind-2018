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

namespace Canvas
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

        private void ButtonShiftClick(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach(FrameworkElement element in CanvasBase.Children)
                {
                    double left = (double)element.GetValue(System.Windows.Controls.Canvas.LeftProperty);
                    left++;
                    element.SetValue(System.Windows.Controls.Canvas.LeftProperty, left);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void ButtonOkClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Your Full Name: {TextBoxFirstName.Text} {TextBoxLastName.Text}");
        }

        private void ButtonShiftRightClick(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (FrameworkElement element in CanvasBase.Children)
                {
                    double left = (double)element.GetValue(System.Windows.Controls.Canvas.LeftProperty);
                    left--;
                    element.SetValue(System.Windows.Controls.Canvas.LeftProperty, left);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
