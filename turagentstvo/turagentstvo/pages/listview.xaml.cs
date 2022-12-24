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
    /// Логика взаимодействия для listview.xaml
    /// </summary>
    public partial class listview : Page
    {
        
        public listview()
        {
            InitializeComponent();

            var allTypes = TourAgencyMDEntities2.GetContext().TourTypes.ToList();
            allTypes.Insert(0, new TourTypes
            {
                TypeName = "Все типы"
            });
            ComboType.ItemsSource = allTypes;

            CheckActual.IsChecked = true;
            ComboType.SelectedIndex = 0;


            var currentTour = TourAgencyMDEntities2.GetContext().Tours.ToList();
            ListTours.ItemsSource = currentTour;
        }

        private void UpdateTours()
        {
            var currentTours = TourAgencyMDEntities2.GetContext().Tours.ToList();
            if (ComboType.SelectedIndex > 0)
            {
                currentTours = currentTours.Where(p => p.TourType.Contains(ComboType.SelectedItem.ToString())).ToList();
            }
            currentTours = currentTours.Where(p=>p.TourName.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
            /*if (CheckActual.IsChecked.Value)
            {
                currentTours = currentTours.Where(p => p.isActual).ToList();
            }*/
            ListTours.ItemsSource = currentTours.OrderBy(p => p.TicketsCount).ToList();   
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateTours();
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTours();
        }

        private void CheckActual_Checked(object sender, RoutedEventArgs e)
        {
            UpdateTours();
        }

        private void CheckActual_Unchecked(object sender, RoutedEventArgs e)
        {
            UpdateTours();
        }
    }
}
