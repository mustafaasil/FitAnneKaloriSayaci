using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAnneKaloriSayaci.DATA.Siniflar
{
    public class Kullanici : AnaSinif
    {

        public string Soyad { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Sifre { get; set; } = null!;

        public string TelefonNo { get; set; } = null!;

        public DateTime DogumTarihi { get; set; }

        public decimal Boy { get; set; }

        public decimal Kilo { get; set; }

        public bool HamileMi { get; set; }

        public byte? HamilelikHaftasi { get; set; }

        [NotMapped]
        public string BirlesikIsim { get { return Ad + "-" + Soyad; } }

        [NotMapped]
        public ICollection<YemekRapor> YemekRaporlari { get; set; }
    }
}
