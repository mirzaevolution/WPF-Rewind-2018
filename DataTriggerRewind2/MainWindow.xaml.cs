using System.Windows;
using System.Windows.Controls;

namespace DataTriggerRewind2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserValidateModel _user;
        public MainWindow()
        {
            _user = new UserValidateModel();
            InitializeComponent();
            DataContext = _user;
            
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void ButtonValidate_Click(object sender, RoutedEventArgs e)
        {
            if (_user.EmployeeID.Trim().Equals("12345", System.StringComparison.InvariantCultureIgnoreCase) &&
               _user.Email.Trim().Equals("ghulamcyber@hotmail.com", System.StringComparison.InvariantCultureIgnoreCase))
            {
                MessageBox.Show("Account Validated Succcessfully", "Validated", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Account Not Found", "Not Found", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
