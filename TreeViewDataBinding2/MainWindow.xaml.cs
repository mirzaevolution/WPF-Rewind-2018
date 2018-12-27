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

namespace TreeViewDataBinding2
{
    public partial class MainWindow : Window
    {
        public List<MenuItem> MenuItems { get; set; }
        public MainWindow()
        {

            MenuItems = new List<MenuItem>();
            MenuItem root = new MenuItem()
            {
                Title = "Menu"
            };
            MenuItem childItem1 = new MenuItem() { Title = "Child item #1" };
            childItem1.Items.Add(new MenuItem() { Title = "Child item #1.1" });
            MenuItem childItemSub = new MenuItem() { Title = "Child item #1.2" };
            childItemSub.Items.Add(new MenuItem { Title = "Child item #1.2.1" });
            childItem1.Items.Add(childItemSub);
            root.Items.Add(childItem1);
            MenuItem childItem2 = new MenuItem() { Title = "Child item #2" };
            childItem2.Items.Add(new MenuItem
            {
                Title = "Child item #2.1"
            });
            root.Items.Add(childItem2);
            MenuItems.Add(root);
            InitializeComponent();

            DataContext = MenuItems;
        }
    }
}
