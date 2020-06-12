using HaliSahaWPF.Models;
using System.Windows;
using System.Windows.Controls;

namespace HaliSahaWPF.Pages
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, RoutedEventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            string name = txt_name.Text.Trim();
            string surname = txt_surname.Text.Trim();
            string email = txt_email.Text.Trim();
            string password = txt_password.Text.Trim();
            kullanicilar.KullaniciAdi = name;
            kullanicilar.KullaniciSoyadi = surname;
            kullanicilar.KullaniciEmail = email;
            kullanicilar.KullaniciSifre = password;

            using (HaliSahaDBEntities db = new HaliSahaDBEntities())
            {
                db.Kullanicilars.Add(kullanicilar);
                db.SaveChanges();
            }
            MessageBox.Show("KULLANICI BAŞARIYLA KAYIT EDİLDİ. GİRİŞ YAPABİLİRSİNİZ.");
        }
    }
}
