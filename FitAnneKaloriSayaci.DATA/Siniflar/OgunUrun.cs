using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAnneKaloriSayaci.DATA.Siniflar
{
    public class OgunUrun
    {
        //Navigation Property
        public int OgunId { get; set; }

        public Ogun Ogun { get; set; }

        //Navigation Property

        public int UrunId { get; set; }

        public Urun Urun { get; set; }
    }
}
