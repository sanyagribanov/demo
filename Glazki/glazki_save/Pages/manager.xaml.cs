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
    /// Логика взаимодействия для manager.xaml
    /// </summary>
    public partial class manager : Page
    {
        DispatcherTimer timerManager = new DispatcherTimer();
        DateTime dateManager = new DateTime(0, 0);

        //имя юзера типа и его должность
        public manager()
        {
            InitializeComponent();
                
            Classes.DBConnect.modeldb = new blagodatEntities9();

            UserTB.Text = Models.blagodatEntities9.GetContext().user.ToString();
            RoleTB.Text = "(" + Models.blagodatEntities9.CurrentUser.role.RoleID + ")";

            var fullFilePath = Models.blagodatEntities9.CurrentUser.img1;

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Relative);
            bitmap.EndInit();

            UserPhoto.Source = bitmap;

            timerManager.Interval = TimeSpan.FromSeconds(1);
            timerManager.Tick += timerTick;
            timerManager.Start();
        }

        //а тута таймер
        private void timerTick(object sender, EventArgs e)
        {
            dateManager = dateManager.AddSeconds(1);
            TimeTB.Text = dateManager.ToString("HH:mm:ss");

            if (TimeTB.Text == "00:00:05")
            {
                MessageBox.Show("Время сеанса подходит к концу!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (TimeTB.Text == "00:00:10")
            {
                timerManager.Stop();
                App.IsGone = true;
                NavigationService.Navigate(new LoginPage());
                MessageBox.Show("Сеанс подошел к концу!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
