using FitAnneKaloriSayaci.DAL.Context;
using FitAnneKaloriSayaci.DATA.Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitAnneKaloriSayaci.UI
{
    public partial class KullaniciDuzenlemeEkraniAdmin : Form
    {
        Kullanici guncellenecekKullanici;
        ProjectContext _db;

        public KullaniciDuzenlemeEkraniAdmin()
        {
            InitializeComponent();
            _db = new ProjectContext();
            Listele();
        }

        private void Listele()
        {
            #region Kullanıcıları Listeleme İşlemleri 
            dgvKullanicilar.DataSource = (from ku in _db.Kullanicilar
                                          select new
                                          {
                                              ku.ID,
                                              ku.Ad,
                                              ku.Soyad,
                                              ku.Email,
                                              ku.TelefonNo,
                                              ku.DogumTarihi,
                                              ku.Boy,
                                              ku.Kilo,
                                              ku.HamileMi,
                                              ku.HamilelikHaftasi,
                                              ku.Sifre
                                          }).ToList();
            #endregion
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            #region Kullanıcı Ekleme İşlemleri     
            try
            {
                if (!Metotlar.BosAlanVarMi(grpKisiselBilgiler) || !Metotlar.BosAlanVarMi(grbİletisimBilgiler) || !Metotlar.BosAlanVarMi(grbSifreBilgiler))
                {
                    if (_db.Kullanicilar.FirstOrDefault(x => x.Email == txtEmail.Text) == null)
                    {
                        if (Metotlar.EmailKontrolEt(txtEmail.Text) && Metotlar.EmailKontrolEt(txtEmail.Text))
                        {
                            if (txtSifre.Text.Trim() == txtSifreTekrari.Text.Trim())
                            {
                                Kullanici yenikullanici = new Kullanici();
                                yenikullanici.Ad = txtAd.Text.Trim();
                                yenikullanici.Soyad = txtSoyad.Text.Trim();
                                yenikullanici.DogumTarihi = dtpDogumTarihi.Value;
                                yenikullanici.Boy = nudBoy.Value;
                                yenikullanici.Kilo = nudKilo.Value;
                                yenikullanici.TelefonNo = txtTelefonNo.Text.Trim();
                                if (Metotlar.EmailKontrolEt(txtEmail.Text.Trim()) || Metotlar.SifreKontrolEt(txtSifre.Text.Trim()))
                                {
                                    yenikullanici.Email = txtEmail.Text.Trim();
                                    yenikullanici.Sifre = txtSifre.Text.Trim();
                                }
                                if (rbtnDogumSonrasi.Checked)
                                {
                                    yenikullanici.HamileMi = rbtnDogumSonrasi.Checked;
                                }
                                else
                                {
                                    yenikullanici.HamileMi = rbtnHamileyim.Checked;
                                    yenikullanici.HamilelikHaftasi = (byte?)nudHamilelikKacinciHafta.Value;
                                }
                                _db.Kullanicilar.Add(yenikullanici);
                                _db.SaveChanges();
                                Listele();
                                MessageBox.Show("Yeni kullanici başarılı bir şekilde eklenmiştir.");
                                Metotlar.Temizle(grpKisiselBilgiler);
                                Metotlar.Temizle(grbSifreBilgiler);
                                Metotlar.Temizle(grbİletisimBilgiler);
                            }
                            else
                            {
                                MessageBox.Show("Girdiğiniz şifreler birbirine uyumlu değildir.Lütfen tekrar giriş yapınız.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Girmeye çalıştığınız kullanıcı sistemde kayıtlıdır, lütfen sistemde kayıtlı olmayan bir kullanıcının bilgilerini girmeye çalışınız");
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen boş alan bırakmayınız");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!" + ex.Message);
            }
            #endregion
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            #region Kullanıcı Silme İşlemleri
            try
            {
                var kullaniciID = dgvKullanicilar.SelectedCells[0].Value;
                var silinenKullanici = _db.Kullanicilar.FirstOrDefault(x => x.ID == (int)kullaniciID);
                _db.Remove(silinenKullanici);
                MessageBox.Show("Kullanıcı silinmiştir.");
                _db.SaveChanges();
                Metotlar.Temizle(grpKisiselBilgiler);
                Metotlar.Temizle(grbSifreBilgiler);
                Metotlar.Temizle(grbİletisimBilgiler);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!" + ex.Message);
            }
            #endregion
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            #region Kullanıcı Güncelleme İşlemleri
            try
            {
                var kullaniciID = dgvKullanicilar.SelectedCells[0].Value;
                guncellenecekKullanici = _db.Kullanicilar.FirstOrDefault(x => x.ID == (int)kullaniciID);

                #region Boşluk İşlemleri
                if (Metotlar.BosAlanVarMi(grpKisiselBilgiler) || Metotlar.BosAlanVarMi(grbİletisimBilgiler) || Metotlar.BosAlanVarMi(grbSifreBilgiler))
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz.");
                    return;
                }
                #endregion
                if (_db.Kullanicilar.Where(x => x.TelefonNo == txtTelefonNo.Text).Count() > 0)
                {
                    MessageBox.Show("Aynı numaralı kullanici mevcuttur.");
                    return;
                }
              

                if (Metotlar.EmailKontrolEt(txtEmail.Text.Trim()) && Metotlar.SifreKontrolEt(txtSifre.Text.Trim()))
                {
                    if (txtSifre.Text.Trim() == txtSifreTekrari.Text.Trim())
                    {
                        
                        guncellenecekKullanici.Ad = txtAd.Text.Trim();
                        guncellenecekKullanici.Soyad = txtSoyad.Text.Trim();
                        guncellenecekKullanici.DogumTarihi = dtpDogumTarihi.Value;
                        guncellenecekKullanici.Boy = nudBoy.Value;
                        guncellenecekKullanici.Kilo = nudKilo.Value;
                        guncellenecekKullanici.Email = txtEmail.Text.Trim();
                        guncellenecekKullanici.Sifre = txtSifre.Text.Trim();
                        guncellenecekKullanici.TelefonNo = txtTelefonNo.Text.Trim();


                        if (rbtnDogumSonrasi.Checked)
                        {
                            guncellenecekKullanici.HamileMi = false;
                            guncellenecekKullanici.HamilelikHaftasi = null;
                        }
                        else
                        {
                            guncellenecekKullanici.HamileMi = rbtnHamileyim.Checked;
                            guncellenecekKullanici.HamilelikHaftasi = (byte?)nudHamilelikKacinciHafta.Value;
                        }
                        MessageBox.Show("Kullanıcı bilgileri güncellenmiştir.");
                        _db.SaveChanges();
                        Metotlar.Temizle(grpKisiselBilgiler);
                        Metotlar.Temizle(grbSifreBilgiler);
                        Metotlar.Temizle(grbİletisimBilgiler);
                        Listele();
                    }

                    else
                    {
                        MessageBox.Show("Girdiğiniz şifreler birbirine uyumlu değildir.Lütfen tekrar giriş yapınız.");
                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!" + ex.Message);
            }
            #endregion
        }

        private void dgvKullanicilar_Click(object sender, EventArgs e)
        {
            Goruntule();
        }

        private void Goruntule()
        {
            #region Alanları Doldurma İşlemleri
            txtAd.Text = dgvKullanicilar.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvKullanicilar.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgvKullanicilar.CurrentRow.Cells[3].Value.ToString();
            txtTelefonNo.Text = dgvKullanicilar.CurrentRow.Cells[4].Value.ToString();
            dtpDogumTarihi.Value = (DateTime)dgvKullanicilar.CurrentRow.Cells[5].Value;
            nudBoy.Value = (decimal)dgvKullanicilar.CurrentRow.Cells[6].Value;
            nudKilo.Value = (decimal)dgvKullanicilar.CurrentRow.Cells[7].Value;
            if ((bool)dgvKullanicilar.CurrentRow.Cells[8].Value)
            {
                rbtnHamileyim.Checked = true;
                lblHamilelikHaftasi.Visible = true;
                nudHamilelikKacinciHafta.Visible = true;
                nudHamilelikKacinciHafta.Value = (byte)dgvKullanicilar.CurrentRow.Cells[9].Value;
            }
            else
            {
                rbtnDogumSonrasi.Checked = true;
                nudHamilelikKacinciHafta.Visible = false;
                lblHamilelikHaftasi.Visible = false;
            }
            txtSifre.Text = dgvKullanicilar.CurrentRow.Cells[10].Value.ToString();
            #endregion
        }

        private void rbtnHamileyim_CheckedChanged(object sender, EventArgs e)
        {
            lblHamilelikHaftasi.Text = "Hamileliğin Kaçıncı Haftası : ";
            nudHamilelikKacinciHafta.Visible = true;
        }

        private void rbtnDogumSonrasi_CheckedChanged(object sender, EventArgs e)
        {
            lblHamilelikHaftasi.Text = "";
            nudHamilelikKacinciHafta.Visible = false;
        }

        private void KullaniciDuzenlemeEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminEkraninaGecisYap();
        }

        private void AdminEkraninaGecisYap()
        {
            AdminEkrani adminEkrani = new AdminEkrani();
            adminEkrani.Show();
            this.Hide();
        }

        private void txtTelefonNo_Click(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate () { txtTelefonNo.Select(0, 0); });
        }
    }
}
