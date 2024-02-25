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
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            int authResult = AuthenticateUser(UserNameBox.Text, UserSurnameBox.Text);
            switch (authResult)
            {
                case 0:
                    MessageBox.Show("Успешный вход!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    PageNavigationManager.MainFrame.Navigate(new MainMenuPage());
                    PageNavigationManager.MainFrame.RemoveBackEntry();
                    break;
                case 1:
                    MessageBox.Show("Неверный айди!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    UserNameBox.Clear();
                    UserSurnameBox.Clear();
                    break;
                case 2:
                    MessageBox.Show("Неверное имя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    UserNameBox.Clear();
                    UserSurnameBox.Clear();
                    break;
            }
        }
        private int AuthenticateUser(string firstName, string surname)
        {
            var context = SaveLifeDBEntities.GetContext().Agents.FirstOrDefault(p => p.FirstName == UserNameBox.Text);

            if(context != null)
            {
                if(context.LastName == surname)
                {
                    return 0;
                }
                return 1;
            }
            return 2;
        }
    }
}
