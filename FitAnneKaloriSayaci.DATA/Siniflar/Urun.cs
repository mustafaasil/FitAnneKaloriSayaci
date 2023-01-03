using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAnneKaloriSayaci.DATA.Siniflar
{
    public class Urun
    {
        public int UrunId { get; set; }

        public string Ad { get; set; } = null!;

        public decimal Kalori { get; set; }

        public string? FotografYolu { get; set; }

        public Byte[]? UrunFotograf { get; set; }

        //Navigation Property

        public int KategoriId { get; set; }

        public Kategori Kategori { get; set; }

        //Navigation Property

        public ICollection<OgunUrun> OgunUrunleri { get; set; }

        [NotMapped]
        public YemekRapor YemekRapor { get; set; }


        [NotMapped]

        public ICollection<YemekRapor> YemekRaporlari { get; set; }
    }
}
