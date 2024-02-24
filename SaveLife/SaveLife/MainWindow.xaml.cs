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
using SaveLife.Pages;
using SaveLife.ManagerScipts;

namespace SaveLife
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new LoginPage());
            PageNavigationManager.MainFrame = mainFrame;
            PageNavigationManager.MainFrame.JournalOwnership = JournalOwnership.OwnsJournal;
            PageNavigationManager.MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }
    }
}
