using FitAnneKaloriSayaci.DAL.Context;
using FitAnneKaloriSayaci.DATA.Siniflar;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitAnneKaloriSayaci.UI
{
    public partial class RaporAlEkrani : Form

    {
        Kullanici aktifKullanici;
        ProjectContext _db;
        public decimal? toplamKalori;

        public RaporAlEkrani(Kullanici kullanici)
        {
            _db = new ProjectContext();
            InitializeComponent();
            aktifKullanici = kullanici;
            GunlukKaloriIhtiyaci();
        }

        private void Listele()
        {
            #region Yemek Raporlarını Listeleme İşlemleri
            dgvRaporlar.DataSource = (from y in _db.YemekRaporlar
                                      join k in _db.Kullanicilar
                                      on y.KullaniciID equals k.ID
                                      where k.Email == aktifKullanici.Email
                                      where y.OlusturulmaTarihi.Date >= dtpBaslangic.Value.Date && y.OlusturulmaTarihi <= dtpBitis.Value.Date
                                      group y by y.OlusturulmaTarihi into group1
                                      select new
                                      {
                                          Tarih = group1.Key,
                                          ToplamKalori = group1.Sum(x => x.KaloriToplam)
                                      }
                                      ).ToList();
            #endregion
        }

        private void GunlukKaloriIhtiyaci()
        {
            #region Günlük Kalori İhtiyacı Hesaplama İşlemleri    
            decimal yas = DateTime.Now.Year - aktifKullanici.DogumTarihi.Year;
            decimal bazalMetabolizma = 655.1m + (9.56m * aktifKullanici.Kilo) + (1.85m * aktifKullanici.Boy) - (4.68m * yas);
            decimal gunlukKalori = bazalMetabolizma * 1.3m;
            if (aktifKullanici.HamileMi)
            {
                if (aktifKullanici.HamilelikHaftasi <= 13)
                {
                    gunlukKalori = bazalMetabolizma * 1.3m;
                }
                else if (aktifKullanici.HamilelikHaftasi >= 14 && aktifKullanici.HamilelikHaftasi <= 26)
                {
                    gunlukKalori = (bazalMetabolizma * 1.3m) + 350;
                }
                else if (aktifKullanici.HamilelikHaftasi >= 27 && aktifKullanici.HamilelikHaftasi <= 40)
                {
                    gunlukKalori = (bazalMetabolizma * 1.3m) + 500;
                }
            }

            lblAlmanGerekenKalori.Text = ((int)gunlukKalori).ToString();

            OgunKaloriGoster();

            if (toplamKalori >= gunlukKalori)
            {
                lblUyari.Text = "Günlük kalori ihtiyacınızı tamamladınız ve aştınız!";
            }
            else
            {
                lblUyari.Text = "Günlük kalori ihtiyacınızı tamamlamadınız!";
            }
            #endregion
        }

        private void OgunKaloriGoster()
        {
            #region Kalorileri Ögunlerde Gösterme ve Toplam Günlük Kaloriyi Gösterme İşlemleri
            var aktifKullaniciOgun = _db.YemekRaporlar.Where(x => x.KullaniciID == aktifKullanici.ID).ToList();
            decimal? toplamKahvalti = 0m;
            decimal? toplamOglen = 0m;
            decimal? toplamAraOgun = 0m;
            decimal? toplamAksam = 0m;
            foreach (var item in aktifKullaniciOgun)
            {
                if (item.OlusturulmaTarihi.Date == DateTime.Now.Date)
                {
                    switch (item.OgunID)
                    {
                        case 1:
                            toplamKahvalti += item.KaloriToplam;
                            break;
                        case 2:
                            toplamOglen += item.KaloriToplam;
                            break;
                        case 3:
                            toplamAraOgun += item.KaloriToplam;
                            break;
                        case 4:
                            toplamAksam += item.KaloriToplam;
                            break;
                    }
                    lblSabah.Text = toplamKahvalti.ToString();
                    lblOglen.Text = toplamOglen.ToString();
                    lblAraOgun.Text = toplamAraOgun.ToString();
                    lblAksam.Text = toplamAksam.ToString();
                    toplamKalori = toplamKahvalti + toplamOglen + toplamAraOgun + toplamAksam;
                    lblToplamKalori.Text = toplamKalori.ToString();
                }
            }
            #endregion
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEnCokTuketilenUrun_Click(object sender, EventArgs e)
        {
            #region En Çok Tüketilen Ürünü Bulma İşlemleri
            var aktifKullaniciEnCokUrun = _db.YemekRaporlar.Where(x => x.KullaniciID == aktifKullanici.ID);
            if (aktifKullaniciEnCokUrun.Count() > 0)
            {
                var EnCok = _db.YemekRaporlar.GroupBy(y => y.UrunID).OrderByDescending(x => x.Count()).Take(1).Select(z => new { Urun = _db.Urunler.FirstOrDefault(x => x.UrunId == z.Key).Ad, Toplam = z.Count() });
                dgvEnCok.DataSource = EnCok.ToList();
            }
            else
            {
                MessageBox.Show("Kullanıcının Eklediği ürün yoktur.");
            }
            #endregion
        }

        private void RaporAlEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            KullaniciAnaEkraninaGecisYap(aktifKullanici);
        }

        private void KullaniciAnaEkraninaGecisYap(Kullanici kullanici)
        {
            KullaniciAnaEkrani kullaniciAnaEkrani = new KullaniciAnaEkrani(kullanici);
            kullaniciAnaEkrani.Show();
            this.Hide();
        }
    }
}
