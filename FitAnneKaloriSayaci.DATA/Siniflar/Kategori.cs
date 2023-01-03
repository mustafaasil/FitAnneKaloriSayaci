using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAnneKaloriSayaci.DATA.Siniflar
{
    public class Kategori :AnaSinif
    {
        public ICollection<Urun> Urunler { get; set; }
    }
}
