using HaliSahaWPF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace HaliSahaWPF.Pages
{
    /// <summary>
    /// Interaction logic for SahaPage.xaml
    /// </summary>
    public partial class SahaPage : Page
    {
        Sahalar sahalar = new Sahalar();
        HaliSahaDBEntities haliSahaDB = new HaliSahaDBEntities();

        public SahaPage()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txt_sahaLimit.Text = "";
            txt_sahaName.Text = "";
            txt_sahaPrice.Text = "";
        }

        public void RefreshData()
        {
            tb1.Items.Refresh();
            tb1.ItemsSource = haliSahaDB.Sahalars.ToList();
            cmbox_saha_data.Items.Refresh();
        }

        private void btn_add_saha_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sahalar.SahaAdı = txt_sahaName.Text.Trim();
                sahalar.SahaFiyati = Convert.ToDecimal(txt_sahaPrice.Text);
                sahalar.SahaKapasitesi = Convert.ToInt32(txt_sahaLimit.Text);
                sahalar.isActive = true;

                using (var context = new HaliSahaDBEntities())
                {
                    context.Sahalars.Add(sahalar);
                    context.SaveChanges();
                }
                MessageBox.Show("SAHA BAŞARIYLA EKLENDİ");
                RefreshData();
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hatayla karşılaşıldı. Lütfen tekrar deneyiniz.");
            }
        }

        private void cmbox_saha_data_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = haliSahaDB.Sahalars.ToList();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshData();
        }

        private void btn_saha_pasif_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var item = cmbox_saha_data.SelectedItem as Sahalar;
                using (var context = new HaliSahaDBEntities())
                {
                    var result = context.Sahalars.SingleOrDefault(b => b.SahaId == item.SahaId);
                    if (result != null)
                    {
                        if (result.isActive != false)
                        {
                            result.isActive = false;
                            MessageBox.Show("Saha Pasif Edildi."); 
                        }
                        else
                        {
                            result.isActive = true;
                            MessageBox.Show("Saha Aktif Edildi."); 
                        }
                        context.SaveChanges();
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Bir hatayla karşılaşıldı. Lütfen tekrar deneyiniz.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hatayla karşılaşıldı. Lütfen tekrar deneyiniz.");
            }
        }

        private void btn_saha_sil_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var item = cmbox_saha_data.SelectedItem as Sahalar;
                using (var context = new HaliSahaDBEntities())
                {
                    var result = context.Sahalars.SingleOrDefault(b => b.SahaId == item.SahaId);
                    if (result != null)
                    {
                        context.Entry(result).State = EntityState.Deleted;
                        context.SaveChanges();
                        MessageBox.Show("Saha Başarıyla Silindi.");
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Bir hatayla karşılaşıldı. Lütfen tekrar deneyiniz.");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hatayla karşılaşıldı. Lütfen tekrar deneyiniz.");
            }
        }
    }
}
