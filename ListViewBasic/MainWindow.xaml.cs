using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ListViewBasic
{
    public class EmployeeData
    {
        public ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>()
        {
            new Employee
            {
                FirstName = "Mirza Ghulam",
                LastName = "Rasyid",
                Email = "ghulamcyber@hotmail.com",
                Department = "Software Engineering"
            },
            new Employee
            {
                FirstName = "Rara",
                LastName = "Anjani",
                Email = "rara.anjani@hotmail.com",
                Department = "Software Engineering"
            },
            new Employee
            {
                FirstName = "Michael",
                LastName = "Hawk",
                Email = "hawk_razor@gmail.com",
                Department = "Software Engineering"
            },
            new Employee
            {
                FirstName = "Sarah",
                LastName = "Ayu",
                Email = "sarahayu09@hotmail.com",
                Department = "Software Engineering"
            },
            new Employee
            {
                FirstName = "Mark",
                LastName = "Zorov",
                Email = "blacktiger451@hotmail.com",
                Department = "Software Engineering"
            },
            new Employee
            {
                FirstName = "Maria",
                LastName = "Wijaya",
                Email = "mwijaya11@gmail.com",
                Department = "Marketing"
            },
            new Employee
            {
                FirstName = "Lisa",
                LastName = "Masayu",
                Email = "sarahayu09@hotmail.com",
                Department = "Marketing"
            },
            new Employee
            {
                FirstName = "Dika",
                LastName = "Rahma",
                Email = "dikarahma091@hotmail.com",
                Department = "Marketing"
            },
            new Employee
            {
                FirstName = "Melisa",
                LastName = "Sari",
                Email = "melisa_sari_ss@gmail.com",
                Department = "Marketing"
            }
        };
    }
    public partial class MainWindow : Window
    {
        private CollectionView _employeeCollectionView;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonSearchClickHandler(object sender, RoutedEventArgs e)
        {
            if (_employeeCollectionView != null)
            {
                if (string.IsNullOrEmpty(TextBoxSearch.Text))
                {
                    _employeeCollectionView.Filter = null;
                }
                else
                {
                    _employeeCollectionView.Filter = (x) =>
                    {
                        Employee emp = x as Employee;
                        string keyword = TextBoxSearch.Text.Trim().ToLower();
                        return emp.FirstName.ToLower().Contains(keyword) ||
                                emp.LastName.ToLower().Contains(keyword) ||
                                emp.Email.ToLower().Contains(keyword);
                    };
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var source = this.TryFindResource("Peoples") as CollectionViewSource;
            if (source != null)
            {
                _employeeCollectionView = source.View as CollectionView;
            }
        }
    }
}
