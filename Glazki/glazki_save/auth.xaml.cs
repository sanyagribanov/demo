using glazki_save.Models;
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

namespace glazki_save
{
    /// <summary>
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Page
    {
        public auth()
        {
            InitializeComponent();
            Classes.DBConnect.modeldb = new Models.gornolyzhnyi_kompleksEntities1();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            try
            {
                //обращение к таблице Юзер для получения Логин и Пассворд
                //var - общий тп переменной
                //userObj - имя объекта. задается самостоятельно. Информация об агенте - agentObj 
                var userObj = Classes.DBConnect.modeldb.user.FirstOrDefault(x => x.Name == login.Text && x.Password == passwd.Password);

                /* if (login.Text == "1" && passwd.Password == "1")
                 {
                     NavigationService.Navigate(new admin());
                 }*/

                if (userObj != null)
                {
                    MessageBox.Show("Здравствуйте " + userObj.role.Title + ", " + userObj.FIO, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    switch (userObj.ID)
                    {
                        case 1:
                            NavigationService.Navigate(new admin());
                            break;
                        case 2:
                            NavigationService.Navigate(new user());
                            break;
                        case 3:
                            NavigationService.Navigate(new manager());
                            break;
                        default:
                            MessageBox.Show("Данные не обнаружены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                    }
                }
                else MessageBox.Show("Пользователя в БД нет", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch
            {
                MessageBox.Show("Ошибка: " + ex.Message.ToString(), "Критическая работа приложения",
        MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ShowPass_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ShowPass.Visibility = Visibility.Collapsed;
            passwd.Visibility = Visibility.Visible;
        }

        private void ShowPass_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowPass.Visibility = Visibility.Visible;
            passwd.Visibility = Visibility.Collapsed;
            ShowPass.Text = passwd.Password;
        }
    }
}

