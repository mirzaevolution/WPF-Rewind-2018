using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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

namespace IntroToMahapps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void ButtonShowMessage_Click(object sender, RoutedEventArgs e)
        {
            var result =  await this.ShowMessageAsync("Title", "Apakah aku tampan?", MessageDialogStyle.AffirmativeAndNegative, new MetroDialogSettings
            {
                AffirmativeButtonText = "Ya, tampan!",
                NegativeButtonText = "Tidak!",
                DefaultButtonFocus = MessageDialogResult.Affirmative 
            });
            if(result == MessageDialogResult.Affirmative)
            {
                await this.ShowMessageAsync("Terima kasih", "Terima kasih atas penilaian anda!", settings: new MetroDialogSettings
                {
                    AnimateShow = false
                });
            }
            else
            {
                
                await this.ShowMessageAsync("Terima kasih", "Baiklah, terima kasih atas ejekan anda!",settings:new MetroDialogSettings
                {
                    AnimateShow = false
                });
            }
        }

        private async void ButtonShowInput_Click(object sender, RoutedEventArgs e)
        {
            string result = await this.ShowInputAsync("Input", "Enter your name", new MetroDialogSettings
            {
                DefaultButtonFocus = MessageDialogResult.Affirmative
            });
            if (!string.IsNullOrEmpty(result))
            {
                await this.ShowMessageAsync("Your Name", $"Your name is {result}!");
            }
        }
    }
}
