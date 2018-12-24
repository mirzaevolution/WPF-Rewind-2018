using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace CollectionViewFilter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Student> Students { get; set; } = new ObservableCollection<Student>()
        {
            new Student
            {
                FirstName = "Mirza Ghulam",  LastName = "Rasyid", Class = "XA", Email="student1@mail.com"
            },
            new Student
            {
                FirstName = "Rara", LastName = "Anjani", Class = "XB", Email ="student2@email.com"
            },
            new Student
            {
                FirstName = "Debby", LastName = "Ayu", Class = "XA", Email = "student3@email.com"
            },
            new Student
            {
                FirstName = "Beggi", LastName = "Mamad", Class = "XB", Email = "student4@email.com"
            },
            new Student
            {
                FirstName = "Shandy", LastName = "Ainun", Class = "XA", Email = "student5@email.com"
            }
        };
        public CollectionView StudentsCollectionView;
        public MainWindow()
        {
            InitStudentsCollectionView();
            InitializeComponent();
            ListBoxData.ItemsSource = StudentsCollectionView;
            
        }
        private void InitStudentsCollectionView()
        {
            StudentsCollectionView = CollectionViewSource.GetDefaultView(Students) as CollectionView;
            StudentsCollectionView.GroupDescriptions.Add(new PropertyGroupDescription("Class"));
            StudentsCollectionView.SortDescriptions.Add(new SortDescription("Class",ListSortDirection.Ascending));
            StudentsCollectionView.SortDescriptions.Add(new SortDescription("FirstName", ListSortDirection.Ascending));
        }
        private void ButtonFilterClickHandler(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(TextBoxSearchName.Text) && string.IsNullOrEmpty(TextBoxSearchClass.Text))
            {

                StudentsCollectionView.Filter = null;
            }
            else
            {

                StudentsCollectionView.Filter = (x) =>
                {
                    var student = x as Student;
                    return
                        string.Concat(student.FirstName, " ", student.LastName).ToLower().Contains(TextBoxSearchName.Text.Trim().ToLower()) &&
                        student.Class.ToLower().Contains(TextBoxSearchClass.Text.ToLower().Trim());
                };
            }
        }
    }
}
