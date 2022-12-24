using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
    /// Логика взаимодействия для AddHotel.xaml
    /// </summary>
    public partial class AddHotel : Page
    {
        private Hotels _currentHotels = new Hotels();
        public AddHotel(Hotels selectedhotel)
        {
            InitializeComponent();
            
            if (selectedhotel != null)
            {
                _currentHotels = selectedhotel;
            }
            DataContext = _currentHotels;

            ComboProducts.ItemsSource = TourAgencyMDEntities2.GetContext().Countrys.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(HotelString.Text))
            {
                errors.AppendLine("Введите название отеля");
            }
            if ( _currentHotels.Stars > 5)
            {
                errors.AppendLine("Слишком много звезд");
            }
            if (_currentHotels.HotelName == null)
            {
                errors.AppendLine("Выберите страну");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentHotels.HotelID == 0)
            {
                TourAgencyMDEntities2.GetContext().Hotels.Add(_currentHotels);
            }

            try
            {
                TourAgencyMDEntities2.GetContext().SaveChanges();
                MessageBox.Show("Отель добавлен!");
                NavigationService.GoBack();
            }
            catch(DbEntityValidationException ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void ComboData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
