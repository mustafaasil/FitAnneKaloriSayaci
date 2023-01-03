using FitAnneKaloriSayaci.DATA.Siniflar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FitAnneKaloriSayaci.DAL.Configuration
{
    public class OgunUrunConfiguration : IEntityTypeConfiguration<OgunUrun>
    {
        public void Configure(EntityTypeBuilder<OgunUrun> builder)
        {
            builder.HasOne(t => t.Urun).WithMany(t => t.OgunUrunleri).HasForeignKey(t => t.OgunId);

            builder.HasOne(t => t.Ogun).WithMany(t => t.OgunUrunleri).HasForeignKey(t => t.UrunId);

            builder.HasKey(k => new
            {
                k.OgunId,
                k.UrunId
            });
        }
    }
}
