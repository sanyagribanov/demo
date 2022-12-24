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
        public Hotels _currentHotels = new Hotels();
        public static TourAgencyMDEntities2 TourData = new TourAgencyMDEntities2();

        public AddHotel()
        {
            InitializeComponent();
            
            DataContext = _currentHotels;

            var allCountries = TourAgencyMDEntities2.GetContext().Countrys.ToList();
            allCountries.Insert(0, new Countrys
            {
                CountryName = "Страна"
            }); ;
            ComboProducts.ItemsSource = allCountries;

            ComboData.ItemsSource= TourAgencyMDEntities2.GetContext().Dates.ToList();
        }

        

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(_currentHotels.HotelName))
            {
                MessageBox.Show("Введите название отеля");
            }

            if (_currentHotels.Stars < 1 || _currentHotels.Stars > 5)
            {
                MessageBox.Show("Слишком много звезд");
            }

            Hotels AddHotels = new Hotels
            {
                HotelName = _currentHotels.HotelName,
                Stars = _currentHotels.Stars,
            };

            var currentCountry = ComboProducts.SelectedItem as Countrys;
            AddHotels.CountryName = currentCountry.CountryName;

            try
            {
                TourData.Hotels.Add(AddHotels);
                TourData.SaveChanges();
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
