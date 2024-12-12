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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        private Partners _currentPartners = new Partners();
        public AddPage(Partners selectedPartners)
        {
            InitializeComponent();
            Type.ItemsSource = Entities1.GetContext().PartnersType.ToList();
            if (selectedPartners != null)
                _currentPartners = selectedPartners;

            DataContext = _currentPartners;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_currentPartners.PartnerID == 0)
                Entities1.GetContext().Partners.Add(_currentPartners);
            try
            {
                Entities1.GetContext().SaveChanges();
                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}