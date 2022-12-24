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
using turagentstvo.pages;
using turagentstvo.resursi;

namespace turagentstvo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new listview());
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new auth());
        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new auth());
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HotelsPage());
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void ExitButton2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        }
    }
}
