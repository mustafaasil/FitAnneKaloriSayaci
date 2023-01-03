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
    public partial class GirisEkrani : Form
    {
        Kullanici kullanici;
        Admin admin;
        ProjeYoneticisi yonetici;
        ProjectContext _db;

        public GirisEkrani()
        {
            InitializeComponent();
            _db = new ProjectContext();
        }

        private void cbSifremiGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = cbSifremiGoster.Checked ? '\0' : '*'; //Giriş ekranında şifre gösterme
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            #region Bosluk Kontrolu
            if (txtEmail.Text == "" || txtSifre.Text == "") //Boşluk kontrolü yapıldı.
            {
                MessageBox.Show("Boş bıraktığınız alanlar var lütfen bu alanları doldurunuz!");
            }
            #endregion

            #region Giris Yapanları AyırtEtme Admin,ProjeYoneticisi veya Kullanici
            if (txtEmail.Text.ToLower().Contains("admin"))
            {
                if (KimlikSorguAdmin())
                {
                    AdminEkraninaGecisYap();
                }
            }
            else if (txtEmail.Text.ToLower().Contains("yonetici"))
            {
                if (KimlikSorguYonetici())
                {
                    ProjeYoneticisiEkraninaGecisYap();
                }
            }
            else
            {
                if (KimlikSorguKullanıcı())
                {
                    KullaniciEkraninaGecisYap();
                }
            }
            #endregion

        }

        private bool KimlikSorguKullanıcı()
        {
            #region kullanıcı İçin Kimlik Sorgulama İşlemleri
            kullanici = _db.Kullanicilar.FirstOrDefault(x => x.Email == txtEmail.Text); //Kullanicilar tablosundan mailleri eşleşenleri bulunuyor.
            if (kullanici != null)
            {
                if (kullanici.Sifre.Trim() == txtSifre.Text.Trim())
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Yanlış şifre girdiniz!");
                    txtSifre.Text = String.Empty;
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Böyle bir hesap bulunmamaktadır!");
                txtEmail.Text = txtSifre.Text = String.Empty;
                return false;
            }
            #endregion
        }

        private bool KimlikSorguAdmin()
        {
            #region Admin İçin Kimlik Sorgulama İşlemleri
            admin = _db.Adminler.FirstOrDefault(x => x.Email == txtEmail.Text); //Kullanicilar tablosundan mailleri eşleşenleri bulunuyor.
            if (admin != null)
            {
                if (admin.Sifre.Trim() == txtSifre.Text.Trim())
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Yanlış şifre girdiniz!");
                    txtSifre.Text = String.Empty;
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Böyle bir hesap bulunmamaktadır!");
                txtEmail.Text = txtSifre.Text = String.Empty;
                return false;
            }
            #endregion
        }

        private bool KimlikSorguYonetici()
        {
            #region ProjeYoneticisi İçin Kimlik Sorgulama İşlemleri
            yonetici = _db.ProjeYoneticiler.FirstOrDefault(x => x.Email == txtEmail.Text);
            if (yonetici != null)
            {
                if (yonetici.Sifre.Trim() == txtSifre.Text.Trim())
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Yanlış şifre girdiniz!");
                    txtSifre.Text = String.Empty;
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Böyle bir hesap bulunmamaktadır!");
                txtEmail.Text = String.Empty;
                txtSifre.Text = String.Empty;
                return false;
            }
            #endregion
        }

        private void lblBirtaneOlustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOlEkraninaGecisYap();
        }

        private void lblSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifreHatirlatmaEkraninaGecisYap();
        }

        private void GirisEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            HosgeldinEkraninaGecisYap();
        }

        private void HosgeldinEkraninaGecisYap()
        {
            Hosgeldin hosgeldin = new Hosgeldin();
            hosgeldin.Show();
            this.Hide();
        }

        private void KayitOlEkraninaGecisYap()
        {
            KayitOlEkrani kayitOlEkrani = new KayitOlEkrani();
            kayitOlEkrani.Show();
            this.Hide();
        }

        private void SifreHatirlatmaEkraninaGecisYap()
        {
            SifreHatirlatma sifreHatirlatma = new SifreHatirlatma();
            sifreHatirlatma.Show();
            this.Hide();
        }

        private void AdminEkraninaGecisYap()
        {
            AdminEkrani adminEkrani = new AdminEkrani();
            adminEkrani.Show();
            this.Hide();
        }

        private void KullaniciEkraninaGecisYap()
        {
            KullaniciAnaEkrani kullaniciAnaEkrani = new KullaniciAnaEkrani(kullanici);
            kullaniciAnaEkrani.Show();
            this.Hide();
        }

        private void ProjeYoneticisiEkraninaGecisYap()
        {
            ProjeYoneticisiEkrani yoneticiEkrani = new ProjeYoneticisiEkrani();
            yoneticiEkrani.Show();
            this.Hide();
        }
    }
}
