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

namespace DataContextRewind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PersonalDetail PersonDetail { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            this.PersonDetail = PersonalDetail.GetDetail();
            DataContext = PersonDetail;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"First Name: {PersonDetail.FirstName}, Last Name: {PersonDetail.LastName}, Age: {PersonDetail.Age}");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }
    }
}
