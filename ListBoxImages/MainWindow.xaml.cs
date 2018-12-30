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
namespace ListBoxImages
{
    public partial class MainWindow : Window
    {
        private void LoadImages()
        {
            string directory = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Images");
            if (Directory.Exists(directory))
            {
                foreach(var image in new DirectoryInfo(directory).GetFiles())
                {
                    ImageModels.Add(new ImageModel
                    {
                        ImageUrl = image.FullName
                    });
                }
            }
        }
        public List<ImageModel> ImageModels { get; set; } = new List<ImageModel>();
        public MainWindow()
        {
            LoadImages();
            InitializeComponent();
            ListboxMain.ItemsSource = ImageModels;
        }
    }
}
