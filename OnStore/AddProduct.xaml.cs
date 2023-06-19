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
using System.Windows.Shapes;

namespace OnStore
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public Product NewProduct { get; set; } = new();
        public AddProduct()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ProductName.Text != "" && ProductContent.Text != "" && ProductImage.Text != "" && ProductPrice.Text != "")
            {
                NewProduct.Name = ProductName.Text;
                NewProduct.Content = ProductContent.Text;
                NewProduct.ImageUrl = ProductImage.Text;
                if(double.TryParse(ProductPrice.Text,out double result)) NewProduct.Price=result;
                MainWindow.Products.Add(NewProduct);
            }
        }
    }
}
