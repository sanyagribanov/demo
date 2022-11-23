using glazki_save.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace glazki_save
{
    /// <summary>
    /// Логика взаимодействия для auth.xaml
    /// </summary>
    public partial class auth : Page
    {
        public auth()
        {
            InitializeComponent();
            UpdateCaptcha();
            Classes.DBConnect.modeldb = new Models.blagodat_1100Entities();
        }
        Random _random = new Random();
        public string Symbols;

        //authorisation

        private void Login(object sender, RoutedEventArgs e)
        {
            try
            {
                //обращение к таблице Юзер для получения Логин и Пассворд
                //var - общий тп переменной
                //userObj - имя объекта. задается самостоятельно. Информация об агенте - agentObj 
                var userObj = Classes.DBConnect.modeldb.user.FirstOrDefault(x => x.Name == login.Text && x.Password == passwd.Password);

                if (userObj != null && (CaptchatextBox.Text == Symbols.ToLower()))
                {
                    blagodat_1100Entities.CurrentUser= userObj;

                    MessageBox.Show("Здравствуйте " + userObj.role.Title + ", " + userObj.FIO, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    switch (userObj.ID)
                    {
                        case 1:
                            NavigationService.Navigate(new admin());
                            break;
                        case 2:
                            NavigationService.Navigate(new manager());
                            break;
                        case 3:
                            NavigationService.Navigate(new smena());
                            break;
                        default:
                            MessageBox.Show("Данные не обнаружены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                    }
                }
                    else MessageBox.Show("Капча не пройдена", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message.ToString(), "Критическая работа приложения", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void ShowPass_MouseUp(object sender, MouseButtonEventArgs e)
        {
            TbxShowPass.Visibility = Visibility.Collapsed;
            passwd.Visibility = Visibility.Visible;
        }

        private void ShowPass_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TbxShowPass.Visibility = Visibility.Visible;
            passwd.Visibility = Visibility.Collapsed;
            TbxShowPass.Text = passwd.Password;
        }


        //captcha
        private void UpdateCaptcha()
        {
            SPanelSymbols.Children.Clear();
            CanvasNoise.Children.Clear();
            GenerateSymbols(4);
            GenerateNoise(30);
        }
        
        private void GenerateSymbols(int count)
        {
            string alphabet = "WERPASFHKXVBM234578";
            for (int i = 0; i < count; i++)
            {
                string symbol = alphabet.ElementAt(_random.Next(0, alphabet.Length)).ToString();
                TextBlock lbl = new TextBlock();
                lbl.Text = symbol;
                lbl.FontSize = _random.Next(20, 30);
                lbl.RenderTransform = new RotateTransform(_random.Next(-20, 20));
                lbl.Margin = new Thickness(10, 30, 10, 10);
                //lbl.Foreground = ra
                SPanelSymbols.Children.Add(lbl);
                Symbols = Symbols + symbol;
            }
        }

        private void GenerateNoise(int volumeNoise)
        {
            for (int i = 0; i < volumeNoise; i++)
            {
                Border border = new Border();
                border.Background = new SolidColorBrush(Color.FromArgb((byte)_random.Next(100, 200),
                                                                       (byte)_random.Next(0, 256),
                                                                       (byte)_random.Next(0, 256),
                                                                       (byte)_random.Next(0, 256)));
                border.Height = _random.Next(2, 10);
                border.Width = _random.Next(10, 60);
                border.RenderTransform = new RotateTransform(_random.Next(0, 30));

                CanvasNoise.Children.Add(border);

                Canvas.SetLeft(border, _random.Next(10, 100));
                Canvas.SetTop(border, _random.Next(10, 80));

                Ellipse ellipse = new Ellipse();
                ellipse.Fill = new SolidColorBrush(Color.FromArgb((byte)_random.Next(100, 200),
                                                                       (byte)_random.Next(0, 256),
                                                                       (byte)_random.Next(0, 256),
                                                                       (byte)_random.Next(0, 256)));
                ellipse.Height = ellipse.Width = _random.Next(10, 20);
                CanvasNoise.Children.Add(ellipse);
                Canvas.SetLeft(ellipse, _random.Next(0, 140));
                Canvas.SetTop(ellipse, _random.Next(10, 80));

            }
        }

        private void BtnUpdateCaptcha1_Click(object sender, RoutedEventArgs e)
        {
            UpdateCaptcha();
        }
        public int count;
    }
}
