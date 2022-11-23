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
    /// Логика взаимодействия для smena.xaml
    /// </summary>
    public partial class smena : Page
    {
        DispatcherTimer timer = new DispatcherTimer();
        DateTime date = new DateTime(0, 0);
        public smena()
        {
            InitializeComponent();

            UserTB_1.Text = bazaEntities1.CurrentUser.FIO;
            RoleTB_1.Text = "(" + bazaEntities1.CurrentUser.role.RoleID + ")";

            var fullFilePath = bazaEntities1.CurrentUser.Avatar;

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Relative);
            bitmap.EndInit();

            UserPhoto_1.Source = bitmap;

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timerTick;
            timer.Start();
        }

        private void timerTick(object sender, EventArgs e)
        {
            date = date.AddSeconds(1);
            TimeTB_1.Text = date.ToString("HH:mm:ss");

            if (TimeTB_1.Text == "00:05:00")
            {
                MessageBox.Show("Время сеанса подходит к концу!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (TimeTB_1.Text == "00:10:00")
            {
                timer.Stop();
                App.IsGone = true;
                NavigationService.Navigate(new admin());
            }
        }
    }
}
