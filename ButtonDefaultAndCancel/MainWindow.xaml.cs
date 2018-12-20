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

namespace ButtonDefaultAndCancel
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

        private void ButtonLoginClickHandler(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(TextBoxUserName.Text) && !string.IsNullOrEmpty(TextBoxPassword.Password))
            {
                if(TextBoxUserName.Text.Equals("mirzaevolution",StringComparison.InvariantCultureIgnoreCase) &&
                   TextBoxPassword.Password.Equals("future", StringComparison.InvariantCultureIgnoreCase))
                {
                    MessageBox.Show("Login successfull", "Access Granted", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Login failed", "Access Denied", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ButtonCancelClickHandler(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
