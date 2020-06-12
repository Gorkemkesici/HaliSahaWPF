using HaliSahaWPF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace HaliSahaWPF.Pages
{
    /// <summary>
    /// Interaction logic for RezervasyonPage.xaml
    /// </summary>
    public partial class RezervasyonPage : Page
    {
        Sahalar sahalar = new Sahalar();
        Rezervasyon rezervasyon = new Rezervasyon();
        HaliSahaDBEntities haliSahaDB = new HaliSahaDBEntities();
        public RezervasyonPage()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            tb_saha_fiyati.Text = "";
            tb_rez_not.Text = "";
        }

        public void RefreshData()
        {
            tb1.Items.Refresh();
            tb1.ItemsSource = haliSahaDB.Rezervasyons.ToList();
            cmbx_sahalar.Items.Refresh();
            cmbx_rez.Items.Refresh();
        }

        private void btn_rez_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var item = cmbx_sahalar.SelectedItem as Sahalar;

                rezervasyon.RezNotu = tb_rez_not.Text.Trim();
                rezervasyon.RezDate = Convert.ToInt32((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds + 2 * 3600);
                rezervasyon.Sahalar.isActive = false;
                rezervasyon.SahaId = item.SahaId;
                using (var context = new HaliSahaDBEntities())
                {
                    context.Rezervasyons.Add(rezervasyon);
                    context.SaveChanges();
                }
                MessageBox.Show("REZERVASYON BAŞARIYLA OLUŞTURULDU");
                RefreshData();
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hatayla karşılaşıldı. Lütfen tekrar deneyiniz.");
            }
        }

        private void cmbx_sahalar_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = haliSahaDB.Sahalars.ToList();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshData();
        }

        private void cmbx_sahalar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = cmbx_sahalar.SelectedItem as Sahalar;
            tb_saha_fiyati.Text = Convert.ToString(item.SahaFiyati);
        }

        private void cmbx_rez_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = haliSahaDB.Rezervasyons.ToList();
        }

        private void btn_rez_iptal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var item = cmbx_rez.SelectedItem as Rezervasyon;
                using (var context = new HaliSahaDBEntities())
                {
                    var result = context.Rezervasyons.SingleOrDefault(b => b.RezID == item.RezID);
                    if (result != null)
                    {
                        context.Entry(result).State = EntityState.Deleted;
                        context.SaveChanges();
                        MessageBox.Show("Rezervasyon Başarıyla Silindi.");
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
