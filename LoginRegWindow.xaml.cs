using HaliSahaWPF.Pages;
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

namespace HaliSahaWPF
{
    /// <summary>
    /// Interaction logic for LoginRegWindow.xaml
    /// </summary>
    public partial class LoginRegWindow : Window
    {
        public LoginRegWindow()
        {
            InitializeComponent();
            LoginPage loginPage = new LoginPage();
            pageLoad(loginPage);
        }

        public void pageLoad(Page pageLoad)
        {
            LoginRegFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            LoginRegFrame.Content = pageLoad;
        }
        
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            pageLoad(loginPage);
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            RegisterPage registerPage = new RegisterPage();
            pageLoad(registerPage);
        }
    }
}
