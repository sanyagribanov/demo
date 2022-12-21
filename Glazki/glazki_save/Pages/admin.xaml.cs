using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
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

            Classes.DBConnect.modeldb = new Models.blagodatEntities9();

            //отображение имени пользователя
            UserTB_2.Text = Models.blagodatEntities9.GetContext().user.ToString();
            RoleTB_2.Text = "(" + Models.blagodatEntities9.GetContext().role.ToString() + ")";

            var fullFilePath = Models.blagodatEntities9.CurrentUser.img1;

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Relative);
            bitmap.EndInit();

            UserPhoto_2.Source = bitmap;

            timerAdmin.Interval = TimeSpan.FromSeconds(1);
            timerAdmin.Tick += timerTick;
            timerAdmin.Start();
        }

        //таймер
        private void timerTick(object sender, EventArgs e)
        {
            dateAdmin = dateAdmin.AddSeconds(1);
            TimeTB_2.Text = dateAdmin.ToString("HH:mm:ss");

            if (TimeTB_2.Text == "00:05:05")
            {
                MessageBox.Show("Время сеанса подходит к концу!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (TimeTB_2.Text == "00:10:10")
            {
                timerAdmin.Stop();
                App.IsGone = true;
                NavigationService.Navigate(new LoginPage());

                MessageBox.Show("Сеанс подошел к концу!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
