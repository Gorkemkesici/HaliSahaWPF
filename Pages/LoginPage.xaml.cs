using HaliSahaWPF.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace HaliSahaWPF.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        Kullanicilar kullanicilar = new Kullanicilar();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            string email = txt_email.Text.Trim();
            string password = txt_password.Text.Trim();
            kullanicilar.KullaniciEmail = email;
            kullanicilar.KullaniciSifre = password;

            using (HaliSahaDBEntities db = new HaliSahaDBEntities())
            {
                var user = db.Kullanicilars.FirstOrDefault(u => u.KullaniciEmail == email);
                if(user != null)
                {
                    if(user.KullaniciSifre == password)
                    {
                        MessageBox.Show("BAŞARIYLA GİRİŞ YAPTINIZ.");
                        MainWindow mainWindow = new MainWindow();
                        this.Visibility = Visibility.Hidden;
                        mainWindow.Show();
                    }
                    else
                    {
                        MessageBox.Show("E-Mail yada Şifre yanlış. Lütfen tekrar deneyiniz.");
                    }
                }
                else
                {
                    MessageBox.Show("KAYITLI KULLANICI BULUNAMADI !");
                }
            }
        }
    }
}
