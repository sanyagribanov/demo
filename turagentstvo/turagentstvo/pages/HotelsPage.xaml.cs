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

namespace turagentstvo.pages
{
    /// <summary>
    /// Логика взаимодействия для HotelsPage.xaml
    /// </summary>
    public partial class HotelsPage : Page
    {
        public HotelsPage()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddHotel(null));

        }
        // удаление данных их таблицы
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var uslugiRemove = DGridClients.SelectedItems.Cast<Hotels>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {uslugiRemove.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    TourAgencyMDEntities2.GetContext().Hotels.RemoveRange(uslugiRemove);
                    TourAgencyMDEntities2.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGridClients.ItemsSource = TourAgencyMDEntities2.GetContext().Hotels.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        // редактирование
        /*private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPage(sender as uslugi).DataContext as uslugi);
        }*/

        // отображение таблицы услуги в виде таблицы
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DGridClients.ItemsSource = TourAgencyMDEntities2.GetContext().Hotels.ToList();
                DGridClients.Items.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
        //функция для фонового отображения таблицы
       /* private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                try
                {
                    TourAgencyMDEntities2.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    DGridClients.ItemsSource = TourAgencyMDEntities2.GetContext().Hotels.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }*/

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddHotel(null));
        }
    }
}
