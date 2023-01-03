using FitAnneKaloriSayaci.DAL.Context;
using FitAnneKaloriSayaci.DATA.Siniflar;
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
    public partial class KullaniciProfilDuzenlemeEkrani : Form
    {
        Kullanici GirisYapankullanici;
        ProjectContext _db;
       

        public KullaniciProfilDuzenlemeEkrani(Kullanici kullanici)
        {
            InitializeComponent();
            _db = new ProjectContext();
            GirisYapankullanici =_db.Kullanicilar.FirstOrDefault(x=>x.Email==kullanici.Email);
            KullaniciBilgileriGetir();
        }

        private void KullaniciProfilDuzenlemeEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            KullaniciAnaEkraniGecisYap(GirisYapankullanici);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            #region Kullanıcı Profil Güncelleme İşlemleri
            try
            {
                if (Metotlar.BosAlanVarMi(grpKisiselBilgiler) || Metotlar.BosAlanVarMi(grpSifreBilgiler) || Metotlar.BosAlanVarMi(grpİletisimBilgiler))
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz.");
                }

                if (GirisYapankullanici != null)
                {
                    GirisYapankullanici.Ad = txtAd.Text.Trim();
                    GirisYapankullanici.Soyad = txtSoyad.Text.Trim();
                    if (Metotlar.SifreKontrolEt(txtSifre.Text) && (txtSifre.Text.Trim()==txtSifreTekrari.Text.Trim()))
                    {
                        GirisYapankullanici.Sifre = txtSifre.Text.Trim();
                    }
                    GirisYapankullanici.Email = GirisYapankullanici.Email;
                    GirisYapankullanici.DogumTarihi = dtpDogumTarihi.Value;
                    GirisYapankullanici.Boy = nudBoy.Value;
                    GirisYapankullanici.Kilo = nudKilo.Value;
                    if (rbtnDogumSonrasi.Checked)
                    {
                        GirisYapankullanici.HamileMi = false;
                        GirisYapankullanici.HamilelikHaftasi = null;

                    }
                    else
                    {
                        GirisYapankullanici.HamileMi = rbtnHamileyim.Checked;
                        GirisYapankullanici.HamilelikHaftasi = (byte)nudHamilelikKacinciHafta.Value;
                      
                    }
                    GirisYapankullanici.TelefonNo = lblTelefonNo.Text;
                    _db.SaveChanges();
                    MessageBox.Show("Güncellenmiştir");
                   // KullaniciAnaEkraniGecisYap(GirisYapankullanici);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!" + ex.Message);
            }
            #endregion
        }

        private void KullaniciBilgileriGetir()
        {
            #region GroupBoxlara Bilgileri Getirme İşlemleri
            if (GirisYapankullanici != null)
            {
                grpKisiselBilgiler.Enabled = true;
                grpSifreBilgiler.Enabled = true;
                lblTelefonNo.Enabled = true;
                txtAd.Text = GirisYapankullanici.Ad.ToString();
                txtSoyad.Text = GirisYapankullanici.Soyad.ToString();
                txtSifre.Text = GirisYapankullanici.Sifre.ToString();
                txtSifreTekrari.Text = GirisYapankullanici.Sifre.ToString();
                lblTelefonNo.Text = GirisYapankullanici.TelefonNo.ToString();
                nudBoy.Value = GirisYapankullanici.Boy;
                nudKilo.Value = GirisYapankullanici.Kilo;
                dtpDogumTarihi.Value = GirisYapankullanici.DogumTarihi;
                if (GirisYapankullanici.HamileMi)
                {
                    rbtnHamileyim.Checked = true;
                    nudHamilelikKacinciHafta.Value = Convert.ToDecimal(GirisYapankullanici.HamilelikHaftasi);
                    lblHamilelikHaftasi.Visible = true;
                }
                else
                {
                    rbtnDogumSonrasi.Checked = true;
                    lblHamilelikHaftasi.Visible = false;
                    nudHamilelikKacinciHafta.Visible = false;

                }
                
            }
            #endregion
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            KullaniciAnaEkraniGecisYap(GirisYapankullanici);
        }

        private void KullaniciAnaEkraniGecisYap(Kullanici kullanici)
        {
            KullaniciAnaEkrani kullaniciAnaEkrani = new KullaniciAnaEkrani(kullanici);
            kullaniciAnaEkrani.Show();
            this.Hide();
        }

        private void rbtnHamileyim_CheckedChanged(object sender, EventArgs e)
        {
            lblHamilelikHaftasi.Text = "Hamileliğin Kaçıncı Haftası: ";
            nudHamilelikKacinciHafta.Visible = true;
        }

        private void rbtnDogumSonrasi_CheckedChanged(object sender, EventArgs e)
        {
            lblHamilelikHaftasi.Text = "";
            nudHamilelikKacinciHafta.Visible = false;
        }

        private void lblTelefonNo_Click(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate () { lblTelefonNo.Select(0, 0); });
        }
    }
}
