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

namespace FoodOrderApps
{
    /// <summary>
    /// Interaction logic for PaymentPage.xaml
    /// </summary>
    public partial class PaymentPage : Page
    {
        public PaymentPage()
        {
            InitializeComponent();
        }

        private void Payment_Click(object sender, RoutedEventArgs e)
        {
            PaymentPage paymentPage = new PaymentPage();
            this.Content = paymentPage;
        }
        private void OpenPaymentPage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PaymentPage());
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            // kembali ke halaman pemesanan
            MainWindow mainWindow = new MainWindow();
            Application.Current.MainWindow.Content = mainWindow.Content;
        }
        private void Cash_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Silakan bayar langsung di kasir yaa 💵", "Bayar Cash");
        }
        private void Qris_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tampilkan QRIS dan lakukan scan melalui aplikasi pembayaran Anda!", "Pembayaran QRIS");
        }
        void Transfer_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Silakan transfer ke rekening 123-456-789 a/n Kantin STBhinneka", "Transfer Bank");
        }
    }
}
