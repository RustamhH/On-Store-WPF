using Bogus;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace OnStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 



    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        

        static public ObservableCollection<Product>? Products { get; set; } = new ObservableCollection<Product>();
        public ObservableCollection<Product>? BuyedProducts { get; set; } = new ObservableCollection<Product>();

        public Product SelectedProduct { get; set; } = new();



        public MainWindow()
        {
            Products.Add(new Product("Coca-Cola","Liquor",20, @"https://www.bakenroll.az/en/image/coca-cola.jpg"));
            Products.Add(new Product("Fanta","Liquor",5000, @"https://static.insales-cdn.com/images/products/1/970/447570890/unnamed-1.jpg"));
            Products.Add(new Product("Lays","Chips",10, @"https://m.media-amazon.com/images/I/8141nrQe0aL._AC_UF894,1000_QL80_.jpg"));
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler? PropertyChanged;


        public void OnPropertyChange([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public ObservableCollection<Product> GenerateFakeData(int itemCount)
        {
            var faker = new Faker<Product>()
                .RuleFor(x => x.Name, f => f.Commerce.ProductName())
                .RuleFor(x => x.Price, f => Convert.ToDouble(f.Commerce.Price()));
                

            var fakeData = faker.Generate(itemCount);
            return new ObservableCollection<Product>(fakeData);
        }

        private void SearchTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchTextBox.Text = "";
            SearchTextBox.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void BuyProduct_Click(object sender, RoutedEventArgs e)
        {
            Product newProduct = new();
            Button button = (sender as Button)!;
            if(button.Parent is StackPanel sp)
            {
                foreach (var item in sp.Children)
                {
                    if(item is Image image)  newProduct.ImageUrl = image.Source.ToString();
                    else if(item is TextBlock tb)
                    {
                        if(tb.Name== "ProductName")  newProduct.Name = tb.Text; 
                        else if(tb.Name== "ProductContent")  newProduct.Content = tb.Text; 
                    }
                    else if(item is WrapPanel wp) if (wp.Children[0] is TextBlock tbw) newProduct.Price = Convert.ToDouble(tbw.Text);
                }
            }
            BuyedProducts!.Add(newProduct);            
        }

        
        private void ShoppingBag_Click(object sender, RoutedEventArgs e)
        {
            BuyedProducts window = new();
            window.MyProducts = this.BuyedProducts;
            window.Show();
        }

        private void listBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            var selectedItem = listBox.SelectedItem;
            var selectedProduct = selectedItem as Product;

            SelectedProduct.Name = selectedProduct.Name;
            SelectedProduct.Content = selectedProduct.Content;
            SelectedProduct.ImageUrl = selectedProduct.ImageUrl;
            SelectedProduct.Price = selectedProduct.Price;

            Stackpanel.Visibility = Visibility.Visible;
            
        }

        private void EditButtom_Click(object sender, RoutedEventArgs e) {
            if(NameTextBox.IsEnabled)
            {
                SelectedProduct.Name = NameTextBox.Text;
                SelectedProduct.Content = ContentTextBox.Text;
                SelectedProduct.ImageUrl = ImageTextBox.Text;
                if(double.TryParse(PriceTextBox.Text,out double result)) SelectedProduct.Price = result;


                var pr = listBox.SelectedItem as Product;
                pr.Name = SelectedProduct.Name;
                pr.Content = SelectedProduct.Content;
                pr.ImageUrl = SelectedProduct.ImageUrl;
                pr.Price = SelectedProduct.Price;

                Stackpanel.Visibility = Visibility.Hidden;
            }
            else NameTextBox.IsEnabled = PriceTextBox.IsEnabled = ContentTextBox.IsEnabled = ImageTextBox.IsEnabled = true;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddProduct window = new();
            window.Show();
        }
    }
}
