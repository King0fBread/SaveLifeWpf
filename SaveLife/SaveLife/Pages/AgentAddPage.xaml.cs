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
using SaveLife.Pages;
using SaveLife.Models;

namespace SaveLife.Pages
{
    /// <summary>
    /// Interaction logic for AgentAddPage.xaml
    /// </summary>
    public partial class AgentAddPage : Page
    {
        public AgentAddPage()
        {
            InitializeComponent();
        }

        private void addSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            SaveLifeDBEntities db = SaveLifeDBEntities.GetContext();
            Agent newAgent = new Agent(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, phoneTextBox.Text, addressTextBox.Text);
            db.Agents.Add(newAgent);
            db.SaveChanges();

            MessageBox.Show("Успешно добавлено!");
            PageNavigationManager.MainFrame.Navigate(new AgentsListPage());
            PageNavigationManager.MainFrame.RemoveBackEntry();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            PageNavigationManager.MainFrame.Navigate(new AgentsListPage());
            PageNavigationManager.MainFrame.RemoveBackEntry();
        }
    }
}
