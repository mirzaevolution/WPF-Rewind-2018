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
using System.IO;
using System.Windows.Threading;
namespace TreeViewLazyLoading
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadDrives();
        }
        private void LoadDrives()
        {
            foreach(DriveInfo drive in DriveInfo.GetDrives())
            {
                try
                {
                    TreeViewFolders.Items.Add(CreateTreeViewItem<DriveInfo>(drive));
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        private void LoadFolders(TreeViewItem item)
        {
            if(item.Items.Count==1 && item.Items[0] is string)
            {
                item.Items.Clear();
                DirectoryInfo dirInfo = null;
                if(item.Tag is DriveInfo)
                {
                    dirInfo = ((DriveInfo)item.Tag).RootDirectory;
                }
                else
                {
                    dirInfo = item.Tag as DirectoryInfo;
                }
                try
                {

                    foreach (var folder in dirInfo.GetDirectories())
                    {
                        try
                        {
                            item.Items.Add(CreateTreeViewItem<DirectoryInfo>(folder));
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        private TreeViewItem CreateTreeViewItem<T>(T data)
        {
            TreeViewItem item = new TreeViewItem
            {
                Header = data.ToString(),
                Tag = data
            };
            item.Items.Add("Loading...");
            return item;
        }

        private void TreeViewFoldersExpandedHandler(object sender, RoutedEventArgs e)
        {
            TreeViewItem treeViewItem = e.Source as TreeViewItem;
            if (treeViewItem != null)
            {
                LoadFolders(treeViewItem);
            }
        }
    }
}
