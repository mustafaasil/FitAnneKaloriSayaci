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
    public partial class SifreHatirlatma : Form
    {
        ProjectContext _db;
        Kullanici kullanici;

        public SifreHatirlatma()
        {
            InitializeComponent();
        }

        private void btnSifreGoster_Click(object sender, EventArgs e)
        {
            #region Sifre Gösterme İşlemleri
            _db = new ProjectContext();
            kullanici = new Kullanici();
            kullanici = _db.Kullanicilar.FirstOrDefault(x => x.TelefonNo == txtTelefonNo.Text);
            if (kullanici != null)
            {
                MessageBox.Show("Şifreniz: " + kullanici.Sifre);
            }
            else
            {
                MessageBox.Show("Yanlış giriş yaptınız!");
            }
            #endregion
        }

        private void SifreHatirlatma_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisEkraninaGecisYap();
        }

        private void GirisEkraninaGecisYap()
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void txtTelefonNo_Click(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate () { txtTelefonNo.Select(0, 0); });
        }
    }
}
