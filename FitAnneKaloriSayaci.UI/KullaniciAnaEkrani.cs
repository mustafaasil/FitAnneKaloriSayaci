using FitAnneKaloriSayaci.DAL.Context;
using FitAnneKaloriSayaci.DATA.Siniflar;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class KullaniciAnaEkrani : Form
    {
        Kullanici GirisYapanKullanici;
        YemekRapor yeniYemekRapor;
        ProjectContext _db;

        public KullaniciAnaEkrani(Kullanici kullanici)
        {
            InitializeComponent();
            _db = new ProjectContext();
            lblGirisYapanKullanici.Text = kullanici.Email;
            GirisYapanKullanici = kullanici;
            KategorileriGetir();
            OgunleriGetir();
            Listele();
        }

        private void Listele()
        {
            #region Günlük Yemek Listeleme İşlemleri
            dgvGunlukYemekListesi.DataSource = (from y in _db.YemekRaporlar
                                                join k in _db.Kullanicilar
                                                on y.KullaniciID equals k.ID
                                                join o in _db.Ogunler
                                                on y.OgunID equals o.OgunId
                                                join ur in _db.Urunler
                                                on y.UrunID equals ur.UrunId
                                                join ka in _db.Kategoriler
                                                on ur.KategoriId equals ka.ID
                                                where k.Email == lblGirisYapanKullanici.Text
                                                select new
                                                {
                                                    y.Id,                            
                                                    Ogun = o.Ad,
                                                    Kategori = ka.Ad,
                                                    Urun = ur.Ad,
                                                    y.Miktar,
                                                    y.KaloriToplam,
                                                    y.Aciklama,
                                                    y.OlusturulmaTarihi
                                                }).ToList();
            #endregion
        }
        private void OgunleriGetir()
        {
            #region ComboBoxa Ogunleri Getirme İşlemleri
            cbOgun.Items.Clear();
            foreach (var item in _db.Ogunler.OrderBy(x => x.OgunId).ToList()) //Ogunler tablosunda idleri artacak sırada comboBoxa itemlerine ekleme yapılmıştır.
            {
                cbOgun.Items.Add(item.Ad);
            }
            cbOgun.SelectedIndex = 0;
            #endregion
        }

        private void KategorileriGetir()
        {
            #region ComboBoxa Kategori Getirme İşlemleri
            cbKategori.Items.Clear();
            foreach (var item in _db.Kategoriler.OrderBy(x => x.ID).ToList()) //Kategoriler tablosunda idleri artacak sırada comboBoxa itemlerine ekleme yapılmıştır.
            {
                cbKategori.Items.Add(item.Ad);
            }
            cbKategori.SelectedIndex = 0;
            #endregion
        }


        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region ComboBoxa Urun Getirme İşlemleri 
            cbUrun.Items.Clear();
            foreach (var item in _db.Urunler.ToList())
            {
                if (item.KategoriId == _db.Kategoriler.FirstOrDefault(x => x.Ad == cbKategori.SelectedItem).ID)
                {
                    cbUrun.Items.Add(item.Ad);

                }
            }
            cbUrun.SelectedIndex = 0;
            #endregion
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            #region YemekRaporlar Listesini Ekleme İşlemleri
            try
            {
                yeniYemekRapor= new YemekRapor();
                var id = _db.Ogunler.FirstOrDefault(x => x.Ad == cbOgun.SelectedItem.ToString()).OgunId;
                var idk = _db.Kategoriler.FirstOrDefault(x => x.Ad == cbKategori.SelectedItem.ToString()).ID;
                var idu = _db.Urunler.FirstOrDefault(x => x.Ad == cbUrun.SelectedItem.ToString()).UrunId;
                var idku = _db.Kullanicilar.FirstOrDefault(x => x.Email == lblGirisYapanKullanici.Text).ID;
                var kaloribul = _db.Urunler.FirstOrDefault(x => x.Ad == cbUrun.SelectedItem.ToString()).Kalori;
                yeniYemekRapor.OgunID = id;
                yeniYemekRapor.KullaniciID = idku;
                yeniYemekRapor.UrunID = idu;
                yeniYemekRapor.Miktar = nudAdet.Value;
                yeniYemekRapor.KaloriToplam = yeniYemekRapor.Miktar * kaloribul;
                yeniYemekRapor.OlusturulmaTarihi = dtpTarih.Value;
                _db.YemekRaporlar.Add(yeniYemekRapor);
                _db.SaveChanges();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            #endregion
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            #region YemekRaporlar Listesini Silme İşlemleri
            try
            {
                var Id = dgvGunlukYemekListesi.SelectedCells[0].Value;
                var silinenListe = _db.YemekRaporlar.FirstOrDefault(x => x.Id == (int)Id); //YemekRaporlar tablosundan aynı Id sahip admin bulunup silme işlemi yapılıyor.
                _db.Remove(silinenListe);
                MessageBox.Show("Yemek Listesi silinmiştir.");
                _db.SaveChanges();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            #endregion
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            #region YemekRaporlar Listesini Güncelleme İşlemleri
            try
            {
                var raporId = dgvGunlukYemekListesi.SelectedCells[0].Value;
                var guncellenecekRapor = _db.YemekRaporlar.FirstOrDefault(x => x.Id == (int)raporId);
                //YemekRaporlar tablosundan aynı Id sahip admin bulunup güncelleme işlemi yapılıyor.
                var id = _db.Ogunler.FirstOrDefault(x => x.Ad == cbOgun.SelectedItem.ToString()).OgunId;
                //Ogunler tablosundan aynı adla eşleşen ogun bulunup YemekRaporlar bulunan foreign key ile Ogunlerde bulunan primary key eşleştiriliyor.
                guncellenecekRapor.OgunID = id;
                var idu = _db.Urunler.FirstOrDefault(x => x.Ad == cbUrun.SelectedItem.ToString()).UrunId;
                //Urunler tablosundan aynı adla eşleşen urun bulunup YemekRaporlar bulunan foreign key ile Urunlerlerde bulunan primary key eşleştiriliyor.
                var kaloribul = _db.Urunler.FirstOrDefault(x => x.Ad == cbUrun.SelectedItem.ToString()).Kalori;
                guncellenecekRapor.UrunID = idu;
                guncellenecekRapor.KaloriToplam = (nudAdet.Value) * kaloribul;
                guncellenecekRapor.Miktar = nudAdet.Value;
                guncellenecekRapor.OlusturulmaTarihi = dtpTarih.Value;
                MessageBox.Show("Rapor bilgileri güncellenmiştir.");
                _db.SaveChanges();
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            #endregion
        }

        private void dgvGunlukYemekListesi_Click(object sender, EventArgs e)
        {
            AlanDoldur();
        }

        private void AlanDoldur()
        {
            #region Alanları Doldurma İşlemleri
            if (dgvGunlukYemekListesi.RowCount>0)
            {
                cbOgun.Text = dgvGunlukYemekListesi.CurrentRow.Cells[1].Value.ToString();
                cbKategori.Text = dgvGunlukYemekListesi.CurrentRow.Cells[2].Value.ToString();
                cbUrun.Text = dgvGunlukYemekListesi.CurrentRow.Cells[3].Value.ToString();
                nudAdet.Value = (decimal)dgvGunlukYemekListesi.CurrentRow.Cells[4].Value;
                dtpTarih.Value = (DateTime)dgvGunlukYemekListesi.CurrentRow.Cells[7].Value; 
            }
            #endregion
        }
        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            RaporAlEkraninaGecisYap();
        }

        private void profilAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciProfilDuzenlemeEkraninaGecisYap();
        }

        private void RaporAlEkraninaGecisYap()
        {
            RaporAlEkrani raporAlEkrani = new RaporAlEkrani(GirisYapanKullanici);
            raporAlEkrani.Show();
            this.Hide();
        }

        private void KullaniciProfilDuzenlemeEkraninaGecisYap()
        {
            KullaniciProfilDuzenlemeEkrani kullaniciProfilDuzenleme = new KullaniciProfilDuzenlemeEkrani(GirisYapanKullanici);
            kullaniciProfilDuzenleme.Show();
            this.Hide();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KullaniciAnaEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
