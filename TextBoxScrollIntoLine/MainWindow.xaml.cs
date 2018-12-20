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

namespace TextBoxScrollIntoLine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TextBoxNote.AutoWordSelection = true;
        }

        private void ButtonFindClickHandler(object sender, RoutedEventArgs e)
        {
            if(TextBoxSearch.Text.Trim()!="" && TextBoxNote.Text.Trim() != "")
            {
                for(int i = 0; i < TextBoxNote.LineCount; i++)
                {
                    string lineText = TextBoxNote.GetLineText(i);
                    if (lineText.ToLower().Contains(TextBoxSearch.Text.ToLower().Trim()))
                    {
                        
                        int len = TextBoxSearch.Text.Length;
                        TextBoxNote.ScrollToLine(i);
                        TextBoxNote.Focus();
                        TextBoxNote.SelectionStart = TextBoxNote.Text.ToLower().IndexOf(TextBoxSearch.Text.ToLower().Trim());
                        TextBoxNote.SelectionLength = len;
                        break;
                    }
                }
            }
        }

        private void TextBoxNote_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBoxLog.Text = $"Caret Index: {TextBoxNote.CaretIndex}";
        }
    }
}
