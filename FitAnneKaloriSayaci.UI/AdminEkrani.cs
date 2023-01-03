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
    public partial class AdminEkrani : Form
    {
        public AdminEkrani()
        {
            InitializeComponent();
        }

        private void KullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciDuzenlemeEkraniAdmin kullaniciDuzenlemeEkrani = new KullaniciDuzenlemeEkraniAdmin();
            kullaniciDuzenlemeEkrani.Show();
            this.Hide();
        }

        private void KategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriDuzenlemeEkraniAdmin kategoriDuzenlemeEkrani = new KategoriDuzenlemeEkraniAdmin();
            kategoriDuzenlemeEkrani.Show();
            this.Hide();
        }

        private void UrunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunDuzenlemeEkraniAdmin urunDuzenlemeEkrani = new UrunDuzenlemeEkraniAdmin();
            urunDuzenlemeEkrani.Show();
            this.Hide();
        }

        private void AdminEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

    }
}
