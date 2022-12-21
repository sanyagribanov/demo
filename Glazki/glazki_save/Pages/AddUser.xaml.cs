using glazki_save.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace glazki_save.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser : Page
    {
        public static blagodatEntities9 AppData = new blagodatEntities9();

        public AddUser()
        {
            InitializeComponent();
            //poJlb noJlb30BaTeJl9 (админ или юзер)
            CmbRole.ItemsSource = AppData.role.ToList();

        }

        // регистрация юзера
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            user AddNewUser = new user
            {
                Name = TBx_Login.Text,
                Password = Classes.md5.HashPassword(PBx_Password.Password),
                FIO = TBx_FIO.Text
            };

            var currentRole = CmbRole.SelectedItem as role;
            AddNewUser.RoleID = currentRole.RoleID;

            AppData.user.Add(AddNewUser);
            AppData.SaveChanges();
            MessageBox.Show("Пользователь добавлен в бд", "Успех");
            NavigationService.GoBack();
        }

        // отображение пароля
        private void ShowPass_Click(object sender, RoutedEventArgs e)
        {
            /*Passwd.Text = Classes.md5.HashPassword(PBx_Password.Password);*/
            Passwd.Text = PBx_Password.Password;
        }
        //хеширование
        private void HashPass_Click(object sender, RoutedEventArgs e)
        {
            Passwd.Text = Classes.md5.HashPassword(PBx_Password.Password);
        }

        //рс2
        private void RC2Pass_Click(object sender, RoutedEventArgs e)
        {
            Passwd.Text = Classes.md5.RC2_password(PBx_Password.Password);
        }
    }
}
