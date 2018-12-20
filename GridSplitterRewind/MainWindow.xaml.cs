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

namespace GridSplitterRewind
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
        private void VerticalSplitter_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            string data = $"#Drag_Started <Vertical Splitter> ({e.HorizontalOffset},{e.VerticalOffset})\n";
            ListBoxLog.Items.Add(data);
            ListBoxLog.ScrollIntoView(data);
        }
        private void VerticalSplitter_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            string data = $"#Drag_Completed <Vertical Splitter> ({e.HorizontalChange},{e.VerticalChange})\n";
            ListBoxLog.Items.Add(data);
            ListBoxLog.ScrollIntoView(data);

        }
        
        private void HorizontalSplitter_DragStarted(object sender, System.Windows.Controls.Primitives.DragStartedEventArgs e)
        {
            string data = $"#Drag_Started <Horizontal Splitter> ({e.HorizontalOffset},{e.VerticalOffset})\n";
            ListBoxLog.Items.Add(data);
            ListBoxLog.ScrollIntoView(data);
        }

        private void HorizontalSplitter_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            string data = $"#Drag_Completed <Horizontal Splitter> ({e.HorizontalChange},{e.VerticalChange})\n";
            ListBoxLog.Items.Add(data);
            ListBoxLog.ScrollIntoView(data);

        }

        private void VerticalSplitter_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            string data = string.Empty;
            if (e.HorizontalChange == 0)
            {
                data = "#Drag_Delta <Vertical_Splitter> is not moving";
            }
            else if (e.HorizontalChange > 0)
            {
                data = "#Drag_Delta <Vertical_Splitter> is moving to the right";

            }
            else
            {
                data = "#Drag_Delta <Vertical_Splitter> is moving to the left";

            }
            ListBoxLog.Items.Add(data);
            ListBoxLog.ScrollIntoView(data);
        }

        private void HorizontalSplitter_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {

            string data = string.Empty;
            if (e.VerticalChange == 0)
            {
                data = "#Drag_Delta <Horizontal_Splitter> is not moving";
            }
            else if (e.VerticalChange > 0)
            {
                data = "#Drag_Delta <Horizontal_Splitter> is moving to the bottom";

            }
            else
            {
                data = "#Drag_Delta <Horizontal_Splitter> is moving to the top";

            }
            ListBoxLog.Items.Add(data);
            ListBoxLog.ScrollIntoView(data);
        }
    }
}
