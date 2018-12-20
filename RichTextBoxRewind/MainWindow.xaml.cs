using System;
using System.IO;
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
using Microsoft.Win32;

namespace RichTextBoxRewind
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

        private void ButtonOpen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    FileName = "",
                    CheckFileExists = true,
                    Filter = "Text File (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf"
                };
                if (openFileDialog.ShowDialog().Value)
                {
                    using(FileStream reader = new FileStream(openFileDialog.FileName,FileMode.OpenOrCreate,FileAccess.Read))
                    {
                        FlowDocument doc = RichTextBoxMain.Document;
                        TextRange textRange = new TextRange(doc.ContentStart, doc.ContentEnd);
                        if (System.IO.Path.GetExtension(openFileDialog.FileName).ToLower().Contains("txt"))
                        {
                            textRange.Load(reader, DataFormats.Text);
                        }
                        else if (System.IO.Path.GetExtension(openFileDialog.FileName).ToLower().Contains("rtf"))
                        {
                            textRange.Load(reader, DataFormats.Rtf);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonNew_Click(object sender, RoutedEventArgs e)
        {
            FlowDocument doc = RichTextBoxMain.Document;
            TextRange textRange = new TextRange(doc.ContentStart, doc.ContentEnd);
            textRange.Text = "";
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    FileName = "",
                    Filter = "Text File (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf"
                };
                if (saveFileDialog.ShowDialog().Value)
                {
                    using (FileStream writer = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {
                        FlowDocument doc = RichTextBoxMain.Document;
                        TextRange textRange = new TextRange(doc.ContentStart, doc.ContentEnd);
                        if (System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower().Contains("txt"))
                        {
                            textRange.Save(writer, DataFormats.Text);
                        }
                        else if (System.IO.Path.GetExtension(saveFileDialog.FileName).ToLower().Contains("rtf"))
                        {
                            textRange.Save(writer, DataFormats.Rtf);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
