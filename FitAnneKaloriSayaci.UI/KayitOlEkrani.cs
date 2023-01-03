using FitAnneKaloriSayaci.DAL.Context;
using FitAnneKaloriSayaci.DATA.Siniflar;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FitAnneKaloriSayaci.UI
{
    public partial class KayitOlEkrani : Form
    {
        ProjectContext _db;
        Kullanici secilenKullanici;

        public KayitOlEkrani()
        {
            InitializeComponent();
            _db = new ProjectContext();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            #region Boşluk Kontrolü
            if (Metotlar.BosAlanVarMi(grpKisiselBilgiler) || Metotlar.BosAlanVarMi(grpSifreBilgiler) || Metotlar.BosAlanVarMi(grpİletisimBilgiler))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız");
                return;
            }
            #endregion

            if (Metotlar.EmailKontrolEt(txtEmail.Text) && Metotlar.SifreKontrolEt(txtSifre.Text)) //Email ve Sifre kriterleri sağlandığı zaman if koşuluna girer.
            {
                KullaniciKayıtEt();
            }
        }

        private void KullaniciKayıtEt()
        {
            #region Kullanıcı Kayıt İşlemleri
            try
            {
                if (_db.Kullanicilar.Where(x => x.Email == txtEmail.Text || x.TelefonNo == lblTelefonNo.Text).Count() > 0)
                { //Kullanıcılar tablosundan aynı mail veya telefon numarası ile eşleşen kullanıcı yoksa if koşuluna girer.
                    MessageBox.Show("Daha önce kaydedilmiş email ve telefon numarası tekrar kullanıcı oluşturulamaz!");
                    return;
                }
                else
                {
                    if (txtSifre.Text == txtSifreTekrari.Text)
                    {
                        secilenKullanici = new Kullanici();
                        secilenKullanici.Ad = txtAd.Text.Trim();
                        secilenKullanici.Soyad = txtSoyad.Text.Trim();
                        secilenKullanici.Email = txtEmail.Text.Trim();
                        secilenKullanici.TelefonNo = lblTelefonNo.Text.Trim();
                        secilenKullanici.Sifre = txtSifre.Text.Trim();
                        secilenKullanici.Boy = nudBoy.Value;
                        secilenKullanici.Kilo = nudKilo.Value;
                        secilenKullanici.DogumTarihi = dtpDogumTarihi.Value;
                        if (rbtnDogumSonrasi.Checked)
                        {
                            secilenKullanici.HamileMi = false;
                        }
                        else
                        {
                            secilenKullanici.HamileMi = rbtnHamileyim.Checked;
                            secilenKullanici.HamilelikHaftasi = (byte?)nudHamilelikKacinciHafta.Value;

                        }
                        _db.Kullanicilar.Add(secilenKullanici);
                        _db.SaveChanges();
                        MessageBox.Show("Kullanıcı Eklenmiştir");
                        Metotlar.Temizle(grpKisiselBilgiler);
                        Metotlar.Temizle(grpSifreBilgiler);
                        Metotlar.Temizle(grpİletisimBilgiler);
                        GirisEkraninaGit();
                    }
                    else
                    {
                        MessageBox.Show("Şifreler birbiriyle eşleşmiyor.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata" + ex.Message);
            }
            #endregion
        }

        private void rbtnDogumSonrasi_CheckedChanged(object sender, EventArgs e)
        {
            lblHamilelikHaftasi.Text = "";
            nudHamilelikKacinciHafta.Visible = false;
        }

        private void rbtnHamileyim_CheckedChanged(object sender, EventArgs e)
        {
            lblHamilelikHaftasi.Text = "Hamileliğin Kaçıncı Haftası: ";
            nudHamilelikKacinciHafta.Visible = true;
        }

        private void lblTelefonNo_Click(object sender, EventArgs e) //MaskedTextBox Click eventi ile imleçin baştan başlanması sağlanmıştır.
        {
            this.BeginInvoke((MethodInvoker)delegate () { lblTelefonNo.Select(0, 0); });
        }

        private void KayitOlEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisEkraninaGit();
        }

        private void GirisEkraninaGit()
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }
    }
}