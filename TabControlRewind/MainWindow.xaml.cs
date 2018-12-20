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

namespace TabControlRewind
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
        public TabItem GetParent(DependencyObject obj)
        {
            DependencyObject checkedObj = VisualTreeHelper.GetParent(obj);
            TabItem tabItem = checkedObj as TabItem;
            if(tabItem!=null)
            {
                return tabItem;
            }
            return GetParent(checkedObj);
        }
        private void ButtonClose(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            
            if (button != null)
            {
                TabItem tabItem = GetParent(button);
                if (tabItem != null)
                {
                    TabControlMain.Items.Remove(tabItem);
                }
            }
           
        }

        private void ButtonAddTabItem_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxTabName.Text.Trim() != "")
            {
                Grid grid = new Grid();
                grid.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength()
                });
                grid.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(40)
                });
                TextBlock textBlock = new TextBlock
                {
                    Text = TextBoxTabName.Text.Trim(),
                    Margin = new Thickness(5),
                    Padding = new Thickness(2)
                };
                textBlock.SetValue(Grid.ColumnProperty, 0);
                Style buttonStyle = this.TryFindResource("ButtonCloseStyle") as Style;
                Button button = new Button
                {
                    Content = "X"
                };
                button.SetValue(Grid.ColumnProperty, 1);
                button.Click += ButtonClose;
                if (buttonStyle != null)
                {
                    button.Style = buttonStyle;
                }
                grid.Children.Add(textBlock);
                grid.Children.Add(button);

                TabItem tabItem = new TabItem();
                tabItem.Header = grid;

                TabControlMain.Items.Add(tabItem);


            }   
        }
    }
}
