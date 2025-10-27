using FoodOrderApps.Models;
using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FoodOrderApps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<CartItem> cartItems = new List<CartItem>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string[] data = button.Tag.ToString().Split('|');
            string name = data[0];
            int price = int.Parse(data[1]);

            cartItems.Add(new CartItem { Name = name, Price = price });
            UpdateCart();
        }

        private void UpdateCart()
        {
            CartList.ItemsSource = null;
            CartList.ItemsSource = cartItems;
            TotalText.Text = "Total: Rp" + cartItems.Sum(x => x.Price).ToString("N0");
        }

        public class CartItem
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return $"{Name} - Rp{Price:N0}";
            }
        }
        private void OrderButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Pesanan Anda sedang diproses!", "Pesan Sekarang");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}