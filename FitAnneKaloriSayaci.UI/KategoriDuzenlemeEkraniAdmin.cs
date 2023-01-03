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
    public partial class KategoriDuzenlemeEkraniAdmin : Form
    {
        ProjectContext _db;
        Kategori yeniKategori;
        Kategori guncellenecekKategori;

        public KategoriDuzenlemeEkraniAdmin()
        {
            _db = new ProjectContext();
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            #region Kategori Listeleme İşlemi
            dgvKategoriler.DataSource = (from ka in _db.Kategoriler //Kategoriler listeleniyor.
                                         select new
                                         {
                                             ka.ID,
                                             ka.Ad
                                         }).ToList();
            #endregion
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            #region Kategori Ekleme İşlemleri
            try
            {
                #region Bosluk Kontrolü
                if (Metotlar.BosAlanVarMi(grpKategoriIslemleri))
                {
                    MessageBox.Show("Boş alan bırakmayınız.");
                }
                #endregion

                if (_db.Kategoriler.Where(x => x.Ad == txtKategori.Text).Count() < 1) //kategorilerde aynı isimde kategori yoksa if koşuluna girer.
                {
                    yeniKategori = new Kategori()
                    {
                        Ad = txtKategori.Text.Trim(),
                    };
                    _db.Kategoriler.Add(yeniKategori);
                    _db.SaveChanges();
                    txtKategori.Text = "";
                    Listele();
                    MessageBox.Show("Kategori sisteme başarılı bir şekilde eklenmiştir.");
                }
                else
                {
                    MessageBox.Show("Aynı isimde Kategori mevcuttur.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            #endregion
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            #region Kategori Silme İşlemleri 
            try
            {
                var Id = dgvKategoriler.SelectedCells[0].Value;
                var silinenKategori = _db.Kategoriler.FirstOrDefault(x => x.ID == (int)Id); 
                //Seçilen satırdaki değer int'e cast edilerek Kategoriler tablosundaki Idlerden biriyle eşleşince silme işlemi yapılıyor.
                _db.Remove(silinenKategori);
                MessageBox.Show("Kategori silinmiştir.");
                _db.SaveChanges();
                txtKategori.Text = "";
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            #endregion
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            #region Kategori Güncelleme İşlemleri  
            try
            {   
                var Id = dgvKategoriler.SelectedCells[0].Value;
                guncellenecekKategori = _db.Kategoriler.FirstOrDefault(x => x.ID == (int)Id);

                #region Bosluk Kontrolü
                if (Metotlar.BosAlanVarMi(grpKategoriIslemleri))
                {
                    MessageBox.Show("Boş alan bırakmayınız.");
                    return;
                }
                #endregion

                guncellenecekKategori.Ad = txtKategori.Text.Trim();
                MessageBox.Show("Kategori bilgileri güncellenmiştir.");
                _db.SaveChanges();
                txtKategori.Text = "";
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            #endregion
        }

        private void dgvKategoriler_DoubleClick(object sender, EventArgs e)
        {
            txtKategori.Text = dgvKategoriler.CurrentRow.Cells[1].Value.ToString();
        }

        private void KategoriDuzenlemeEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminEkraninaGecisYap();
        }

        private void AdminEkraninaGecisYap()
        {
            AdminEkrani adminEkrani = new AdminEkrani();
            adminEkrani.Show();
            this.Hide();
        }
    }
}
