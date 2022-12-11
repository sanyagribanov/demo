using glazki_save.Classes;
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

namespace glazki_save.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser : Page
    {
        public static blagodatEntities8 AppData = new blagodatEntities8();
        
        public AddUser()
        {
            InitializeComponent();

            CmbRole.ItemsSource = AppData.role.ToList();
                
        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            user AddNewUser = new user();

            AddNewUser.Name = TBx_Login.Text;
            AddNewUser.Password = Classes.md5.HashPassword(PBx_Password.Password);
            AddNewUser.FIO = TBx_FIO.Text;

            var currentRole = CmbRole.SelectedItem as role;
            AddNewUser.RoleID = currentRole.RoleID;

            AppData.user.Add(AddNewUser);
            AppData.SaveChanges();
            MessageBox.Show("Пользователь добавлен в бд", "Успех");
            NavigationService.GoBack();
        }

        private void ShowPass_Click(object sender, RoutedEventArgs e)
        {
            /*Passwd.Text = Classes.md5.HashPassword(PBx_Password.Password);*/
            Passwd.Text = PBx_Password.Password;
        }

        private void HashPass_Click(object sender, RoutedEventArgs e)
        {
            Passwd.Text = Classes.md5.HashPassword(PBx_Password.Password);
        }

        private void rc2Pass_Click(object sender, RoutedEventArgs e)
        {
            Passwd.Text = rc2.CryptoPass(PBx_Password.Password);
        }
    }
}
