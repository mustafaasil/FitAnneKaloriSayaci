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
    public partial class AdminDuzenlemeEkrani : Form
    {
        Admin guncellenecekAdmin;
        Admin yeniAdmin;
        ProjectContext _db;

        public AdminDuzenlemeEkrani()
        {
            InitializeComponent();
            _db = new ProjectContext();
            Listele();
        }

        private void Listele()
        {
            dgvAdminler.DataSource = _db.Adminler.ToList(); //Adminler Listeleniyor.
        }

        private void btnAdminEkle_Click(object sender, EventArgs e)
        {
            #region Admin Ekleme İşlemleri
            try
            {
                #region Boşluk Kontrolu
                if (Metotlar.BosAlanVarMi(grpAdminIslemleri))
                {
                    MessageBox.Show("Lütfen boş alan bırakmayınız");
                    return;
                }
                #endregion

                if (_db.Adminler.Where(x => x.Email == txtAdminEmail.Text).Count() < 1) //Adminler tablosunda aynı maile sahip admin yoksa if koşuluna girer.
                {
                    if (txtAdminSifre.Text.Trim() == txtAdminSifreTekrari.Text.Trim()) //Şifreler eşleşirse ekleme işlemi başlıyor.
                    {
                        yeniAdmin = new Admin()
                        {
                            Email = txtAdminEmail.Text.Trim(),
                            Sifre = txtAdminSifre.Text.Trim()
                        };
                        _db.Adminler.Add(yeniAdmin);
                        _db.SaveChanges();
                        Metotlar.Temizle(grpAdminIslemleri);
                        Listele();
                        MessageBox.Show("Admin sisteme başarılı bir şekilde eklenmiştir.");
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz şifreler birbirine uyumlu değildir.Lütfen tekrar giriş yapınız.");
                    }
                }
                else
                {
                    MessageBox.Show("Girmeye çalıştığınız sistemde kayıtlıdır, lütfen sistemde kayıtlı olmayan bir adminin bilgilerini girmeye çalışınız");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            #endregion
        }

        private void btnAdminSil_Click(object sender, EventArgs e)
        {
            #region Admin Silme İşlemleri
            try
            {
                var adminID = dgvAdminler.SelectedCells[0].Value;
                var silinenAdmin = _db.Adminler.FirstOrDefault(x => x.AdminId == (int)adminID); //Adminler tablosundan aynı Id sahip admin bulunup silme işlemi yapılıyor.
                _db.Remove(silinenAdmin);
                MessageBox.Show("Admin silinmiştir.");
                _db.SaveChanges();
                Metotlar.Temizle(grpAdminIslemleri);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            #endregion
        }

        private void btnAdminGuncelle_Click(object sender, EventArgs e)
        {
            #region Admin Güncelleme İşlemleri
            try
            {
                var adminID = dgvAdminler.SelectedCells[0].Value;
                guncellenecekAdmin = _db.Adminler.FirstOrDefault(x => x.AdminId == (int)adminID); //Adminler tablosundan aynı Id sahip admin bulunup silme işlemi yapılıyor.

                #region  Boşluk Kontrolü
                if (Metotlar.BosAlanVarMi(grpAdminIslemleri))
                {
                    MessageBox.Show("Lütfen boş alan bırakmayınız");
                    return;
                }
                #endregion

                if (txtAdminSifre.Text.Trim() == txtAdminSifreTekrari.Text.Trim())
                {
                    guncellenecekAdmin.Email = txtAdminEmail.Text.Trim();
                    guncellenecekAdmin.Sifre = txtAdminSifre.Text.Trim();
                    MessageBox.Show("Adminin bilgileri güncellenmiştir.");
                    _db.SaveChanges();
                    Metotlar.Temizle(grpAdminIslemleri);
                    Listele();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz şifreler birbirine uyumlu değildir.Lütfen tekrar giriş yapınız.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);
            }
            #endregion
        }

        private void dgvAdminler_DoubleClick(object sender, EventArgs e)
        {
            Goruntule();
        }

        private void Goruntule()
        {
            txtAdminEmail.Text = dgvAdminler.CurrentRow.Cells[1].Value.ToString();
            txtAdminSifre.Text = dgvAdminler.CurrentRow.Cells[2].Value.ToString();
        }

        private void AdminDuzenlemeEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProjeYoneticisiEkraninaGecisYap();
        }

        private void ProjeYoneticisiEkraninaGecisYap()
        {
            ProjeYoneticisiEkrani projeYoneticisiEkrani = new ProjeYoneticisiEkrani();
            projeYoneticisiEkrani.Show();
            this.Hide();
        }
    }
}
