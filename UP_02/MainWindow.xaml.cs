﻿using System;
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

namespace UP_02
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           partnersListView.ItemsSource= Entities.GetContext().Partners.ToList();
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
            NavigationService.
        }
    }
}