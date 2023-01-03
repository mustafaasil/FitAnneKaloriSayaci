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
    public partial class ProjeYoneticisiEkrani : Form
    {
        public ProjeYoneticisiEkrani()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminDuzenlemeEkrani adminDuzenlemeEkrani = new AdminDuzenlemeEkrani();
            adminDuzenlemeEkrani.Show();
            this.Hide();
        }

        private void kullaniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciDuzenlemeEkraniProjeYoneticisi kullaniciDuzenlemeEkrani2 = new KullaniciDuzenlemeEkraniProjeYoneticisi();
            kullaniciDuzenlemeEkrani2.Show();
            this.Hide();
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriDuzenlemeEkraniProjeYoneticisi kategoriDuzenlemeEkrani2 = new KategoriDuzenlemeEkraniProjeYoneticisi();
            kategoriDuzenlemeEkrani2.Show();
            this.Hide();
        }

        private void urunToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            UrunDuzenlemeEkrani2 urunDuzenlemeEkrani2 = new UrunDuzenlemeEkrani2();
            urunDuzenlemeEkrani2.Show();
            this.Hide();
        }

        private void ProjeYoneticisiEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }
    }
}
