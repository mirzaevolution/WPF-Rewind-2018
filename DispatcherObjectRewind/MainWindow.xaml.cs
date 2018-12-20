using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace DispatcherObjectRewind
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
        private void InvokeCounter()
        {
            if (this.CheckAccess())
            {
               for(int i = 1; i <= 100; i++)
                {
                    ListBoxCounter.Items.Add(i);
                    ListBoxCounter.ScrollIntoView(i);
                    ProgressBarCounter.Value = i;
                    Thread.Sleep(100);
                }
            }
            else
            {
                for (int i = 1; i <= 100; i++)
                {
                    this.Dispatcher.Invoke(() =>
                    {
                        ListBoxCounter.Items.Add(i);
                        ListBoxCounter.ScrollIntoView(i);
                        ProgressBarCounter.Value = i;
                        Thread.Sleep(100);

                    },System.Windows.Threading.DispatcherPriority.Background);
                }
               
            }
        }
        private void ButtonStartParallelEvent(object sender, RoutedEventArgs e)
        {
            ListBoxCounter.Items.Clear();
            ProgressBarCounter.Value = 0;

            Task.Run(() => InvokeCounter());
        }

        private void ButtonStartNormalEvent(object sender, RoutedEventArgs e)
        {
            ListBoxCounter.Items.Clear();
            ProgressBarCounter.Value = 0;

            InvokeCounter();
        }
    }
}
