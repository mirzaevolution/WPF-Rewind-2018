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
using Newtonsoft.Json;
namespace WPF_Rewind_2018
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Profile _profile = new Profile();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonShowJsonClick(object sender, RoutedEventArgs e)
        {
            _profile.FirstName = textBoxFirstName.Text;
            _profile.LastName = textBoxLastName.Text;
            _profile.DateOfBirth = datePickerDateOfBirth.SelectedDate.HasValue ? datePickerDateOfBirth.SelectedDate.Value : DateTime.Now;
            if (radioButtonMale.IsChecked.Value)
                _profile.Sex = "Male";
            else
                _profile.Sex = "Female";
            string json = JsonConvert.SerializeObject(_profile, Formatting.Indented);
            MessageBox.Show(json, "Simple Form");
        }
    }
}
