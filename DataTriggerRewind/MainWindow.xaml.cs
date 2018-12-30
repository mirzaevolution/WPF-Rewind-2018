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

namespace DataTriggerRewind
{
    public class DataObject
    {
        public int Value { get; set; }
    }
    public partial class MainWindow : Window
    {
        public DataObject DataObject { get; set; } = new DataObject();
        public MainWindow()
        {
            DataObject.Value = 50;
            InitializeComponent();
            DataContext = DataObject;
        }
    }
}
