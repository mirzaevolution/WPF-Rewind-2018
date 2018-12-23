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

namespace ListBoxMultipleRewind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonShowSelectionClickHandler(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var item in ListBoxMain.SelectedItems)
            {
                ListBoxItem listBoxItem = item as ListBoxItem;
                if (listBoxItem != null)
                {
                    sb.AppendLine(listBoxItem.Content.ToString());
                }
            }
            MessageBox.Show(sb.ToString(), "Selected Items", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
