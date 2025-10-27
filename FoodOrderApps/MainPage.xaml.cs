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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Masuk_Click(object sender, RoutedEventArgs e)
        {
            // Saat tombol "Masuk" diklik, pindah ke halaman pemesanan (MainWindow)
            MainWindow mainWindow = new MainWindow();
            Application.Current.MainWindow.Content = mainWindow.Content;
        }
        private void MasukButton_Click(object sender, RoutedEventArgs e)
        {
            // Arahkan ke halaman utama (MainWindow)
            MainWindow mainWindow = new MainWindow();
            Application.Current.MainWindow.Content = mainWindow.Content;
        }
    }
}
