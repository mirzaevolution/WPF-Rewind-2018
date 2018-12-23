using System.Threading;
using System.Windows;

namespace AsyncBinding
{
    public class Person
    {
        private string _firstName,_lastName;
        public Person()
        {
            _firstName = "Mirza Ghulam";
            _lastName = "Rasyid";
        }
        public string FirstName
        {
            get
            {
                Thread.Sleep(5000);
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                Thread.Sleep(5000);
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonLoadBindingClickHandler(object sender, RoutedEventArgs e)
        {

            DataContext = new Person();
        }
    }
}
