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
    /// Логика взаимодействия для captcha.xaml
    /// </summary>
    public partial class captcha : Page
    {
        public captcha()
        {
            InitializeComponent();
            UpdateCaptcha();
        }
        Random _random = new Random();
        public string Symbols;

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //обращение к таблице Юзер для получения Логин и Пассворд
                //var - общий тп переменной
                //userObj - имя объекта. задается самостоятельно. Информация об агенте - agentObj 
                Models.blagodatEntities8 database = new blagodatEntities8();

                var userObj = database.user.FirstOrDefault();

                if (userObj != null && (CaptchatextBox.Text == Symbols.ToLower()))
                {
                    /*blagodatEntities.CurrentUser = userObj;*/

                    MessageBox.Show("Здравствуйте " + userObj.role.Title + ", " + userObj.FIO, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    switch (userObj.ID)
                    {
                        case 1:
                            NavigationService.Navigate(new admin());
                            break;
                        case 2:
                            NavigationService.Navigate(new ProductPage());
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
    }
}

