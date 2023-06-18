﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace OnStore
{
    /// <summary>
    /// Interaction logic for BuyedProducts.xaml
    /// </summary>
    public partial class BuyedProducts : Window
    {
        public ObservableCollection<Product>? MyProducts { get; set; } = new ObservableCollection<Product>();
        public BuyedProducts()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(MyProducts[0].ToString());
        }
    }
}
