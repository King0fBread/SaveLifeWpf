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
using SaveLife.ManagerScipts;
using SaveLife.Models;

namespace SaveLife.Pages
{
    /// <summary>
    /// Interaction logic for OrdersListPage.xaml
    /// </summary>
    public partial class OrdersListPage : Page
    {
        private List<SalesHistory> _availableSales;
        public OrdersListPage()
        {
            InitializeComponent();

            _availableSales = SaveLifeDBEntities.GetContext().SalesHistories.ToList();
            DGOrders.ItemsSource = _availableSales;
        }

        private void MainMenu_Click(object sender, RoutedEventArgs e)
        {
            PageNavigationManager.MainFrame.Navigate(new MainMenuPage());
            PageNavigationManager.MainFrame.RemoveBackEntry();
        }
    }
}
