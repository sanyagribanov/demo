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
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
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
            NavigationService.Navigate(new EditPage(null));

        }
        // удаление данных их таблицы
        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var uslugiRemove = DGridClients.SelectedItems.Cast<uslugi>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {uslugiRemove.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question)==MessageBoxResult.Yes)
            {
                try
                {
                    blagodatEntities9.GetContext().uslugi.RemoveRange(uslugiRemove);
                    blagodatEntities9.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGridClients.ItemsSource = blagodatEntities9.GetContext().uslugi.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        // редактирование
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPage(sender as uslugi).DataContext as uslugi);
        }

        // отображение таблицы услуги в виде таблицы
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DGridClients.ItemsSource = blagodatEntities9.GetContext().uslugi.ToList();
                DGridClients.Items.Refresh();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
        //функция для фонового отображения таблицы
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                try
                {
                    blagodatEntities9.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    DGridClients.ItemsSource = blagodatEntities9.GetContext().uslugi.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
/*⢀⢀⣠⣶⡶⠾⠿⠶⣶⣶⣤⣤⣤⠀⠀⠀⠀⢠⣤⣤⣴⣶⣶⣾⠿⠷⢶⣮⣖⠄
⠁⠛⠁⠀⠀⠀⠤⠤⠤⠤⠤⠉⠁⠀⠀⠀⠀⠀⠈⠉⠀⠀⠀⠀⠄⠀⠀⠀⠉⠓
⠀⠀⠀⠀⠊⢹⣿⣿⣿⠙⡆⠀⠳⠀⠀⠀⠀⠀⠇⠀⡼⠋⣿⣿⣿⠉⠑⠄⠀⠀
⠀⠀⠀⠈⠉⠉⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠉⠉⠉⠉⠀⠀⠀ ⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠂⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠀⢠⠃⠀⠀
⠀⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣀⡤⠴⠚⠁⠀⠀⡎⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠙⠉⠉⠉⠉⠉⠉⠉⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠰⠀  АГА, КОПИРУЕШ!!⠀*/