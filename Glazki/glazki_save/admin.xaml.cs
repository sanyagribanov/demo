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

namespace glazki_save
{
    /// <summary>
    /// Логика взаимодействия для admin.xaml
    /// </summary>
    public partial class admin : Page
    {
        gornolyzhnyi_kompleksEntities2 dataentities= new gornolyzhnyi_kompleksEntities2();
        public admin()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
            from product in dataentities.zakazy
            orderby product.clients
            select new { product.id, product.code, CategoryName = product.date_creation, product.time };

            datagrid_1.ItemsSource = query.ToList();
        }
    }
}
