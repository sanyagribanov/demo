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
using turagentstvo.pages;

namespace turagentstvo.resursi
{
    /// <summary>
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Page
    {
        Random _random = new Random();
        public auth()
        {
            InitializeComponent();
            classes.DataBaseConnect.modeldb = new TourAgencyMDEntities2();

            UpdateCaptcha();
        }

        private void UpdateCaptcha()
        {
            Symbols = "";
            SPanelSymbols.Children.Clear();
            CanvasNoise.Children.Clear();

            GenerateSymbols(3);
            GenerateNoise(30);
        }

        public string Symbols = "";

        private void GenerateSymbols(int count)
        {
            string alphabet = "WERPASFHKXVBM234578";
            for (int i = 0; i < count; i++)
            {
                string symbol = alphabet.ElementAt(_random.Next(0, alphabet.Length)).ToString();
                TextBlock lbl = new TextBlock();



                lbl.Text = symbol;
                lbl.FontSize = _random.Next(20, 40);
                lbl.RenderTransform = new RotateTransform(_random.Next(-45, 45));
                lbl.Margin = new Thickness(20, 20, 20, 20);



                //lbl.Foreground = ra



                SPanelSymbols.Children.Add(lbl);

                Symbols += symbol;
            }
        }

        private void GenerateNoise(int volumeNoise)
        {
            for (int i = 0; i < volumeNoise; i++)
            {
                Ellipse ellipse = new Ellipse
                {
                    Fill = new SolidColorBrush(Color.FromArgb((byte)_random.Next(100, 200),

                     (byte)_random.Next(0, 256),
                     (byte)_random.Next(0, 256),
                     (byte)_random.Next(0, 256)))
                };

                ellipse.Height = ellipse.Width = _random.Next(20, 60);

                Canvas.SetLeft(ellipse, _random.Next(0, 290));
                Canvas.SetTop(ellipse, _random.Next(0, 100));

                CanvasNoise.Children.Add(ellipse);
            }
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            try
            {
                //Обратиться к таблице User, чтобы извлечь логин и пароль
                //var - общий тип
                //userObj - имя обьекта 
                //Информация об агенте - agentObj
                //папка, класс, модель, таблица
                //сравнить данные из таблицы и названия столбцов логин и пароль
                //Имена текстблоков с их функция текст и пароль
                //&& - И пользователь доллжен ввести и логин и пароль, иначе ошибка

                var userObj = classes.DataBaseConnect.modeldb.User.FirstOrDefault(x =>
                x.login == LoginUs.Text && x.Password == Password.Password);

                /*if(LoginUs.Text=="test" && Password.Password=="test")
                {
                 //Manager.MainFrame.Navigate(new Administrator());
                }*/

                if (userObj != null && (GetCapcha.Text == Symbols))
                {
                    models.TourAgencyMDEntities2.currentuser = userObj;
                    MessageBox.Show("Здравствуйте " + userObj.Role.Title + ", " + userObj.login, "Уведомление",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                    switch (userObj.ID)
                    {
                        case 1:
                            NavigationService.Navigate(new pages.admin());
                            break;
                        case 2:
                            NavigationService.Navigate(new pages.user());
                            break;
                        default:
                            MessageBox.Show("Данные не обнаружены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                    }
                }
                else MessageBox.Show("Пользователя в БД нет", "Уведомление");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message.ToString(), "Критическая работа приложения",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void TbxShowPass_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxbPassword.Visibility = Visibility.Visible;
            Password.Visibility = Visibility.Collapsed;
            TxbPassword.Text = Password.Password;
        }
        /// <summary>
        /// Пароль скрывается
        /// </summary>
        private void TbxShowPass_MouseUp(object sender, MouseButtonEventArgs e)
        {
            TxbPassword.Visibility = Visibility.Collapsed;
            Password.Visibility = Visibility.Visible;
        }

        private void BtnUpdateCaptcha_Click(object sender, RoutedEventArgs e)
        {
            UpdateCaptcha();
        }

        private void RegButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new registr());
        }
    }
}
