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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page

        //обновление данных из таблицы услуги
    {
        public uslugi _currentUsluga = new uslugi();

        // запись в таблицу услуги
        public EditPage(uslugi usluga)
        {
            InitializeComponent();

            if (usluga != null)
                _currentUsluga = usluga;

            DataContext = _currentUsluga;
            ComboProducts.ItemsSource = blagodatEntities9.GetContext().uslugi.ToList();
        }

/*        public EditPage(Button button)
        {
            Button = button;
        }

        public Button Button { get; }*/


        //сохранение
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentUsluga.title))
                errors.AppendLine("Укажите наименование услуги");
            if (_currentUsluga.price == null)
                errors.AppendLine("Укажите стоимость");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_currentUsluga.ID == 0)
                blagodatEntities9.GetContext().uslugi.Add(_currentUsluga);

            try
            {
                blagodatEntities9.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена", "Успех");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                
        }
    }
}
