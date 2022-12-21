using glazki_save.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace glazki_save
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        //обращение к бд
        public static blagodatEntities9 Context = new blagodatEntities9();

        //иницилизация юзера
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var currentUser = Context.user.FirstOrDefault(p => p.Name == TBoxLogin.Text && p.Password == PBoxPassword.Password);
            if (currentUser != null)
            {;
                MessageBox.Show("Здравствуйте " + ", " + currentUser.FIO + "\nПройдите капчу", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.Navigate(new Pages.captcha());
            }

            else
            {
                MessageBox.Show("Пользователь с такими данными не найден!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //кнопка регистрации нового юзера
        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate (new Pages.AddUser());
        }
    }
}
