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
using SaveLife.Models;
using SaveLife.ManagerScipts;

namespace SaveLife.Pages
{
    
    public partial class AgentsListPage : Page
    {
        private List<Agent> _availableAgents;
        public AgentsListPage()
        {
            InitializeComponent();

            _availableAgents = SaveLifeDBEntities.GetContext().Agents.ToList();
            DGAgents.ItemsSource = _availableAgents;
        }

        private void MainMenu_Click(object sender, RoutedEventArgs e)
        {
            PageNavigationManager.MainFrame.Navigate(new MainMenuPage());
            PageNavigationManager.MainFrame.RemoveBackEntry();
        }

        private void EditAgent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddAgent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteAgent_Click(object sender, RoutedEventArgs e)
        {
            var agentsToRemove = DGAgents.SelectedItems.Cast<Agent>().ToList();
            if (MessageBox.Show("Удалить агента?", "Подтвердите удаление", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                SaveLifeDBEntities.GetContext().Agents.RemoveRange(agentsToRemove);
                SaveLifeDBEntities.GetContext().SaveChanges();
                MessageBox.Show("Выбранные агенты удалены!");

                DGAgents.ItemsSource = SaveLifeDBEntities.GetContext().Agents.ToList();
            }
        }
    }
}
