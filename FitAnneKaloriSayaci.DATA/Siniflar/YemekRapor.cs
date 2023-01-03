using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FitAnneKaloriSayaci.DATA.Siniflar
{
    [Index(nameof(OgunID), IsUnique = false)]
    [Index(nameof(UrunID), IsUnique = false)]

    public class YemekRapor
    {
        public int Id { get; set; }

        public int KullaniciID { get; set; }
        public virtual Kullanici Kullanici { get; set; }

        public int OgunID { get; set; }
        public virtual Ogun Ogun { get; set; }

        public int UrunID { get; set; }
        public virtual Urun Urun { get; set; }

        public decimal Miktar { get; set; }

        public decimal? KaloriToplam { get; set; }

        public string? Aciklama { get; set; }

        public DateTime OlusturulmaTarihi { get; set; }

    }
}
