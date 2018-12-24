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

namespace TreeViewBasic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TreeViewItem _selectedItem;
        public MainWindow()
        {
            InitializeComponent();
        }
        public string GetFullPath(DependencyObject item, ref List<string> paths)
        {
            TreeViewItem treeViewItem = item as TreeViewItem;
            if (treeViewItem == null)
            {
                return paths.Aggregate((current, next) => next + @"\" + current );
            }
            paths.Add(treeViewItem.Header.ToString());
            return GetFullPath(treeViewItem.Parent, ref paths);
        }
        private void TreeViewCoreSelectedItemChangedHandler(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            _selectedItem = TreeViewCore.SelectedItem as TreeViewItem;
            if (_selectedItem != null)
            {
                if (_selectedItem.Tag != null && _selectedItem.Tag.ToString().Equals("Root", StringComparison.InvariantCultureIgnoreCase))
                {
                    ButtonAddItem.IsEnabled = true;
                }
                else
                {
                    ButtonAddItem.IsEnabled = false;
                }
            }
        }

        private void ButtonAddItemClickHandler(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(TextBoxAddItem.Text) && _selectedItem != null)
            {

                if (_selectedItem != null)
                {
                    if(_selectedItem.Tag!=null && _selectedItem.Tag.ToString().Equals("Root", StringComparison.InvariantCultureIgnoreCase))
                    {
                        TreeViewItem newItem = new TreeViewItem
                        {
                            Header = TextBoxAddItem.Text
                        };
                        _selectedItem.Items.Add(newItem);
                        TextBoxAddItem.Text = "";
                        _selectedItem.ExpandSubtree();
                    }
                }
            }
        }

        private void TreeViewCoreDoubleClickHandler(object sender, MouseButtonEventArgs e)
        {
            var list = new List<string>();
            string path = GetFullPath(_selectedItem, ref list);
            MessageBox.Show(path, "Full Path", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
