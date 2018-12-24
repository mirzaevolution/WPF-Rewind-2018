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

namespace TreeViewDataBinding1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpDataContext();
        }
        private void SetUpDataContext()
        {
            var ferral = new Team("Ferral Motorsport");
            var roseCow = new Team("Rose Cow Racing");
            var mercredi = new Team("Mercredi Racing");
            var mcmillan = new Team("McMillan Mercredi");
            var forcedIndy = new Team("Forced Indy Motors");
            var catering = new Team("Catering Cars");

            var manufacturers = new TeamClass("Manufacturer Teams")
            {
                Teams = new List<Team> { ferral, mercredi, catering }
            };
            var customerTeams = new TeamClass("Customer Teams")
            {
                Teams = new List<Team> { roseCow, mcmillan, forcedIndy }
            };
            DataContext = new List<TeamClass> { manufacturers, customerTeams };
        }
    }
}
