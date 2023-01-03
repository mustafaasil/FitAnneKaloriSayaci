using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAnneKaloriSayaci.DATA.Siniflar
{
    public class ProjeYoneticisi
    {
        [Key]
        public int ProjeYoneticisiId { get; set; }
        
        public string Email { get; set; } = null!;

        public string Sifre { get; set; } = null!;
    }
}
