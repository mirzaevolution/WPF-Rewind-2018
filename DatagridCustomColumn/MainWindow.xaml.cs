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

namespace DatagridCustomColumn
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee("Mirza Ghulam","Rasyid","ghulamcyber@hotmail.com",true,new DateTime(1995,10,21),new DateTime(2018,08,06),"Indonesia",
                "http://www.facebook.com",
                new List<string>
                {
                    "ASP.NET MVC",
                    "ASP.NET Web API",
                    "WPF",
                    "Winforms",
                    "HTML5, CSS and Javascript",
                    "SQL Server"
                }),
                new Employee("Rara","Anjani","raraanjani@gmail.com",true,new DateTime(1996,12,30),new DateTime(2018,07,10),"Indonesia",
                "http://www.facebook.com",
                new List<string>
                {
                    "ASP.NET MVC",
                    "SQL Server"
                }),
                new Employee("Beggi","Mamad","beggimamad07@hotmail.com",false,new DateTime(1993,07,21),new DateTime(2017,10,29),"Malaysia",
                "http://www.facebook.com",
                new List<string>
                {
                    "ASP.NET MVC",
                    "SQL Server",
                    "Microsoft Azure"
                }),
                new Employee("Michael","Hawk","Hawk812@hackermail.com",false,new DateTime(1991,09,15),new DateTime(2018,01,20),"Australia",
                "http://www.facebook.com",
                new List<string>
                {
                    "ASP.NET MVC",
                    "SQL Server",
                    "WPF"
                })
            };
            DataGridBasic.ItemsSource = employees;
            //ColumnCountry.ItemsSource = new List<string>
            //{
            //    "Indonesia",
            //    "Malaysia",
            //    "Singapore",
            //    "Australia",
            //    "USA",
            //    "UK"
            //};
        }

        private void ButtonShowSelectedClickHandler(object sender, RoutedEventArgs e)
        {
            try
            {
                var selectedItem = DataGridBasic.SelectedItem;
                if (selectedItem is Employee employee)
                {
                    MessageBox.Show($"First Name: {employee.FirstName}\n" +
                                    $"Last Name: {employee.LastName}\n" +
                                    $"Email: {employee.Email}\n" +
                                    $"Url: {employee.Url}\n" +
                                    $"Date of Birth: {employee.DateOfBirth.ToLongDateString()}\n" +
                                    $"Date Accepted: {employee.DateAccepted.ToLongDateString()}");
                }
                //var selectedCells = DataGridBasic.SelectedCells;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

     

        private void DataGridBasic_Click(object sender, RoutedEventArgs e)
        {
            Hyperlink hyperlink = e.OriginalSource as Hyperlink;
            if (hyperlink != null)
            {
                System.Diagnostics.Process.Start(hyperlink.NavigateUri.ToString());
            }
        }
    }
}
