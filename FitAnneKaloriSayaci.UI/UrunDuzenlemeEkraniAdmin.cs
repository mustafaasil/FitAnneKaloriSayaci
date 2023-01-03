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
    public partial class UrunDuzenlemeEkraniAdmin : Form
    {
        ProjectContext _db;
        Urun yeniUrun;

        public UrunDuzenlemeEkraniAdmin()
        {
            InitializeComponent();
            _db = new ProjectContext();
            KategorileriGetir();
            Listele();
        }

        private void Listele()
        {
            #region Ürünleri DataGridViewde Listeleme İşlemleri
            dgvUrunler.DataSource = (from ur in _db.Urunler
                                     join ka in _db.Kategoriler
                                     on ur.KategoriId equals ka.ID
                                     select new
                                     {
                                         ur.UrunId,
                                         ur.Ad,
                                         ur.Kalori,
                                         KategoriAd = ka.Ad,
                                         ur.UrunFotograf
                                     }).ToList();
            #endregion
        }

        private void KategorileriGetir()
        {
            #region ComboBoxın İçine Kategorileri Getirme İşlemleri
            cmbKategori.Items.Clear();
            foreach (var item in _db.Kategoriler.OrderBy(x => x.ID).ToList())
            {
                cmbKategori.Items.Add(item.Ad);
            }
            cmbKategori.SelectedIndex = 0;
            #endregion
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            #region Ürün Ekleme İşlemleri
            try
            {
                yeniUrun = new Urun();
                var id = _db.Kategoriler.FirstOrDefault(x => x.Ad == cmbKategori.SelectedItem.ToString()).ID;

                #region Boşluk Kontrolleri            
                if (Metotlar.BosAlanVarMi(grpUrunIslemleri))
                {
                    MessageBox.Show("Bos alanları doldurunuz.");
                    return;
                }
                #endregion

                if (_db.Urunler.Where(x => x.Ad == txtAd.Text.Trim()).Count() < 1)
                {
                    yeniUrun.Ad = txtAd.Text.Trim();
                    yeniUrun.Kalori = nudKalori.Value;
                    yeniUrun.KategoriId = id;
                    if (pbUrunResmi.Image != null)
                    {
                        yeniUrun.FotografYolu = Guid.NewGuid() + pbUrunResmi.Tag.ToString();
                        yeniUrun.UrunFotograf = (Byte[])pbUrunResmi.Tag;
                        pbUrunResmi.Image.Save(Application.StartupPath + "/Fotograflar/" + yeniUrun.FotografYolu);
                    }
                    _db.Urunler.Add(yeniUrun);
                    _db.SaveChanges();
                    Metotlar.Temizle(grpUrunIslemleri);
                    Listele();
                    MessageBox.Show("Urun sisteme başarılı bir şekilde eklenmiştir.");
                }
                else
                {
                    MessageBox.Show("Aynı isimde urun mevcuttur.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!" + ex.Message);
            }
            #endregion
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region Alanları Doldurma İşlemleri
            txtAd.Text = dgvUrunler.CurrentRow.Cells[1].Value.ToString();
            nudKalori.Value = (decimal)dgvUrunler.CurrentRow.Cells[2].Value;
            cmbKategori.Text = dgvUrunler.CurrentRow.Cells[3].Value.ToString();
            if (!string.IsNullOrWhiteSpace(_db.Urunler.FirstOrDefault(x => x.UrunId == (int)dgvUrunler.CurrentRow.Cells[0].Value).FotografYolu))
            {
                pbUrunResmi.Image = Image.FromFile("Fotograflar/" + _db.Urunler.FirstOrDefault(x => x.UrunId == (int)dgvUrunler.CurrentRow.Cells[0].Value).FotografYolu);
                pbUrunResmi.Tag = Path.GetExtension(_db.Urunler.FirstOrDefault(x => x.UrunId == (int)dgvUrunler.CurrentRow.Cells[0].Value).FotografYolu);
            }
            else
            {
                pbUrunResmi.Image = null;
            }
            #endregion
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            #region Ürün Güncelleme İşlemleri
            try
            {
                Urun guncellenecekUrun;
                var Id = dgvUrunler.SelectedCells[0].Value;
                guncellenecekUrun = _db.Urunler.FirstOrDefault(x => x.UrunId == (int)Id);
                guncellenecekUrun.Ad = txtAd.Text.Trim();
                guncellenecekUrun.Kalori = nudKalori.Value;
                guncellenecekUrun.KategoriId = _db.Kategoriler.FirstOrDefault(x => x.Ad == cmbKategori.SelectedItem.ToString()).ID;
                if (pbUrunResmi.Image != null)
                {
                    guncellenecekUrun.FotografYolu = Guid.NewGuid() + pbUrunResmi.Tag.ToString();
                    guncellenecekUrun.UrunFotograf = (Byte[])pbUrunResmi.Tag;
                    pbUrunResmi.Image.Save(Application.StartupPath + "/Fotograflar/" + guncellenecekUrun.FotografYolu);
                }
                MessageBox.Show("Urun guncellenmiştir");
                _db.SaveChanges();
                Metotlar.Temizle(grpUrunIslemleri);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!" + ex.Message);
            }
            #endregion
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            #region Ürün Silme İşlemleri
            try
            {
                var Id = dgvUrunler.SelectedCells[0].Value;
                var silinenUrun = _db.Urunler.FirstOrDefault(x => x.UrunId == (int)Id);
                _db.Remove(silinenUrun);
                MessageBox.Show("Urun silinmiştir.");
                _db.SaveChanges();
                Metotlar.Temizle(grpUrunIslemleri);
                Listele();
            }
            catch
            (Exception ex)
            {
                MessageBox.Show("Hata!" + ex.Message);
            }
            #endregion
        }

        private void UrunDuzenlemeEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminEkraninaGecisYap();
        }

        private void AdminEkraninaGecisYap()
        {
            AdminEkrani adminekrani = new AdminEkrani();
            adminekrani.Show();
            this.Hide();
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Urun Resmi(png, jpg, gif)|*.png;*.jpg;*.gif";
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pbUrunResmi.Image = Image.FromFile(ofd.FileName);
                pbUrunResmi.Tag = File.ReadAllBytes(ofd.FileName);
            }
        }
    }
}
