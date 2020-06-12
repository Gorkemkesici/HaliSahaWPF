using HaliSahaWPF.Pages;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace HaliSahaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SahaPage sahaPage = new SahaPage();
            pageLoad(sahaPage);
        }

        public void pageLoad(Page pageLoad)
        {
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainFrame.Content = pageLoad;
        }

        private void Saha_Click(object sender, RoutedEventArgs e)
        {
            SahaPage sahaPage = new SahaPage();
            pageLoad(sahaPage);
        }

        private void RezShow_Click(object sender, RoutedEventArgs e)
        {
            RezervasyonPage rezervasyonPage = new RezervasyonPage();
            pageLoad(rezervasyonPage);
        }
    }
}
