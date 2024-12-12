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

namespace UP_02.Pages
{
    /// <summary>
    /// Логика взаимодействия для PartnersPage.xaml
    /// </summary>
    public partial class PartnersPage : Page
    {
        public PartnersPage()
        {
            InitializeComponent();
            partnersListView.ItemsSource = Entities1.GetContext().Partners.ToList();
        }
        private void partnersListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            /*if (partnersListView.SelectedItem is Partners selectedItem)
            {
                NavigationService.Navigate(new PartnerHistory(selectedItem));
            }*/

            if (partnersListView.SelectedItem is Partners selectedItem)
            {
                //   NavigationService.Navigate(new AddEditPage(selectedItem))
            }


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage(null));
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage((sender as Button).DataContext as Partners));
        }
    }
}
