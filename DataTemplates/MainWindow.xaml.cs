using System.Windows;

namespace DataTemplates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ContactList();
        }

        private void ButtonAddClickHandler(object sender, RoutedEventArgs e)
        {
            var contacts = DataContext as ContactList;
            if (contacts != null)
            {
                contacts.AddEditableContact();
            }
        }
    }
}
