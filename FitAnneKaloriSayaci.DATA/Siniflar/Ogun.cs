using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAnneKaloriSayaci.DATA.Siniflar
{
    public class Ogun 
    {

        public int OgunId { get; set; }

        public string Ad { get; set; } = null!;

        public  ICollection<OgunUrun> OgunUrunleri { get; set; }

        [NotMapped]

        public YemekRapor yemekRapor { get; set; }


        [NotMapped]

        public ICollection<YemekRapor> YemekRaporlari { get; set; }

    }
}
