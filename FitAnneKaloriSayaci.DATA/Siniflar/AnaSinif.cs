using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAnneKaloriSayaci.DATA.Siniflar
{
    //[Index(nameof(Ad), IsUnique = true)]
    public class AnaSinif
    {
        [Column(Order = 1)]
        public int ID { get; set; }
        [Column(Order = 2)]      
        public string Ad { get; set; } = null!;   
    }
}
