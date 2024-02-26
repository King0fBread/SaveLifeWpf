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

    public partial class AgentEditPage : Page
    {
        private Agent _selectedAgent = new Agent();
        public AgentEditPage(Agent selectedAgent)
        {
            InitializeComponent();
            _selectedAgent = selectedAgent;
            agentDataCanvas.DataContext = _selectedAgent;
        }

        private void redactSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (CheckGameInfoValidity(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text))
            {
                SaveLifeDBEntities.GetContext().SaveChanges();

                MessageBox.Show("Успешно изменено");
                PageNavigationManager.MainFrame.Navigate(new AgentsListPage());
                PageNavigationManager.MainFrame.RemoveBackEntry();
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            PageNavigationManager.MainFrame.Navigate(new AgentsListPage());
            PageNavigationManager.MainFrame.RemoveBackEntry();
        }
        private bool CheckGameInfoValidity(string firstName, string lastName, string email)
        {
            if (firstName.Length < 3)
            {
                MessageBox.Show("Слишком короткое имя!");
                return false;
            }
            if (lastName.Length < 3)
            {
                MessageBox.Show("Слишком короткая фамилия!");
                return false;
            }
            if (!email.Contains("@"))
            {
                MessageBox.Show("Невозможная почта!");
                return false;
            }

            return true;
        }
    }
}
