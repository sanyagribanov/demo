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
using System.Windows.Threading;

namespace glazki_save
{
    /// <summary>
    /// Логика взаимодействия для admin.xaml
    /// </summary>
    public partial class admin : Page
    {
        DispatcherTimer timerAdmin = new DispatcherTimer();
        DateTime dateAdmin = new DateTime(0, 0);
        public admin()
        {
            InitializeComponent();

            UserTB_2.Text = blagodat_1100Entities.CurrentUser.FIO;
            RoleTB_2.Text = "(" + blagodat_1100Entities.CurrentUser.role.RoleID + ")";

            var fullFilePath = blagodat_1100Entities.CurrentUser.img1;

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Relative);
            bitmap.EndInit();

            UserPhoto_2.Source = bitmap;

            timerAdmin.Interval = TimeSpan.FromSeconds(1);
            timerAdmin.Tick += timerTick;
            timerAdmin.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            dateAdmin = dateAdmin.AddSeconds(1);
            TimeTB_2.Text = dateAdmin.ToString("HH:mm:ss");

            if (TimeTB_2.Text == "00:05:00")
            {
                MessageBox.Show("Время сеанса подходит к концу!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (TimeTB_2.Text == "00:10:00")
            {
                timerAdmin.Stop();
                App.IsGone = true;
                NavigationService.Navigate(new admin());
            }
        }
    }
}
