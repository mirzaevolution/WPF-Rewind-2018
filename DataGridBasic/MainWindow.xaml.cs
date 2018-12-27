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

namespace DataGridBasic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AdventureWorks2016CTP3Entities _context;
        public MainWindow()
        {
            _context = new AdventureWorks2016CTP3Entities();
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                this.Dispatcher.Invoke(() =>
                {

                    var data = _context.vEmployees.Select(v => new
                    {
                        v.FirstName,
                        v.LastName,
                        v.EmailAddress,
                        v.PhoneNumber
                    }).ToList();
                    DataGridMaster.ItemsSource = data;
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
