using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FitAnneKaloriSayaci.UI
{
    public static class Metotlar
    {
        public static bool BosAlanVarMi(GroupBox grp)
        {
            foreach (var item in grp.Controls)
            {
                if (item is TextBox && ((TextBox)item).Text == string.Empty)
                {
                    return true;
                }
                else if (item is ComboBox && ((ComboBox)item).SelectedIndex == -1)
                {
                    return true;
                }
                else if (item is NumericUpDown && ((NumericUpDown)item).Value == 0)
                {
                    return true;
                }
                else if (item is MaskedTextBox && ((MaskedTextBox)item).MaskFull == false)
                {
                    return true;
                }
            }
            return false;
        }

        public static void Temizle(GroupBox grp)
        {
            foreach (var item in grp.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = string.Empty;
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).ResetText();
                }
                else if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Text = "";
                }
                else if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).ResetText();
                }
            }
        }

        public static bool EmailKontrolEt(string mail)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.Match(mail).Success)
            {
                MessageBox.Show("Email Adresinizi Uygun Formatta Yazınız.");
                return false;
            }
            return true;
        }

        public static bool SifreKontrolEt(string sifrem)
        {
            if (string.IsNullOrEmpty(sifrem))
            {
                return false;
            }
            char[] sifre = sifrem.ToCharArray();
            int numaraSayisi = 0;
            int kucukHarfSayisi = 0;
            int buyukHarfSayisi = 0;
            int ozelKarakterSayisi = 0;

            if (sifre.Length < 8 || sifre.Length > 16)
            {
                MessageBox.Show("Girmiş olduğunuz şifre 8 ile 16 karakter arasında olmalıdı!");
                return false;
            }
            foreach (char item in sifre)
            {
                int ascOfItem = (int)item;
                if (ascOfItem >= 48 && ascOfItem <= 57)
                {
                    numaraSayisi++;
                }
                else if (ascOfItem >= 97 && ascOfItem <= 122)
                {
                    kucukHarfSayisi++;
                }
                else if (ascOfItem >= 65 && ascOfItem <= 90)
                {
                    buyukHarfSayisi++;
                }
                else if (ascOfItem >= 33 && ascOfItem <= 47)
                {
                    ozelKarakterSayisi++;
                }
            }
            if (numaraSayisi < 1)
            {
                MessageBox.Show("Girmiş olduğunuz şifre içerisinde en az 1 tane sayı olmalıdır!");
                return false;
            }
            else if (kucukHarfSayisi < 1)
            {
                MessageBox.Show("Girmiş olduğunuz şifre içerisinde en az 1 tane küçük harf olmalıdır!");
                return false;
            }
            else if (buyukHarfSayisi < 1)
            {
                MessageBox.Show("Girmiş olduğunuz şifre içerisinde en az 1 tane büyük harf olmalıdır!");
                return false;
            }
            else if (ozelKarakterSayisi < 1)
            {
                MessageBox.Show("Girmiş olduğunuz şifre içerisinde en az 1 tane özel karakter olmalıdır!");
                return false;
            }
            return true;
        }
    }
}
