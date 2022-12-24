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
using turagentstvo.classes;
using turagentstvo.models;
using turagentstvo.resursi;

namespace turagentstvo.pages
{
    /// <summary>
    /// Логика взаимодействия для admin.xaml
    /// </summary>
    public partial class admin : Page
    {
        DispatcherTimer timer = new DispatcherTimer();
        DateTime date = new DateTime(0, 0);

        public admin()
        {
            InitializeComponent();

            UserTB_2.Text = TourAgencyMDEntities2.currentuser.login;
            RoleTB_2.Text = "(" + TourAgencyMDEntities2.currentuser.Role.Title + ")";

            var fullFilePath = TourAgencyMDEntities2.currentuser.avatar;

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(fullFilePath, UriKind.Relative);
            bitmap.EndInit();

            admin123.Source = bitmap;

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timerTick;
            timer.Start();
        }

        //логика таймера
        private void timerTick(object sender, EventArgs e)
        {
            date = date.AddSeconds(1);
            TimeTB_2.Text = date.ToString("T");

            if (TimeTB_2.Text == "00:00:30")
            {
                MessageBox.Show("Время сеанса подходит к концу!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (TimeTB_2.Text == "00:00:20")
            {
                App.IsGone = true;
                timer.Stop();
                Manager.MainFrame.Navigate(new auth());
            }
        }
    }
}
