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
using turagentstvo.models;

namespace turagentstvo.pages
{
    /// <summary>
    /// Логика взаимодействия для registr.xaml
    /// </summary>
    public partial class registr : Page
    {
        public static TourAgencyMDEntities2 AppData = new TourAgencyMDEntities2();
        public registr()
        {
            InitializeComponent();

        }

        private void Login(object sender, RoutedEventArgs e)
        {
            User AddNewUser = new User
            {
                login = LoginUs.Text,
                Password = Password.Password,
            };

            if (Password.Password != PasswordDop.Password)
            {
                MessageBox.Show("Неверный ввод пароля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            AppData.User.Add(AddNewUser);
            AppData.SaveChanges();
            MessageBox.Show("Пользователь добавлен в бд", "Успех");
            NavigationService.GoBack();
        }
        private void TbxShowPass_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxbPassword.Visibility = Visibility.Visible;
            Password.Visibility = Visibility.Collapsed;
            TxbPassword.Text = Password.Password;

        }

        private void TbxShowPass_MouseUp(object sender, MouseButtonEventArgs e)
        {
            TxbPassword.Visibility = Visibility.Collapsed;
            Password.Visibility = Visibility.Visible;
        }

        private void LoginUs_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
