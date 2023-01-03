using FitAnneKaloriSayaci.DATA.Siniflar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitAnneKaloriSayaci.DAL.Configuration
{
    public class KullaniciConfiguration : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(x => x.ID); //Tablonun PK kolonu olarak belirlendi.
           
            builder.Property(x => x.DogumTarihi).HasColumnType("date").IsRequired();

            builder.Property(x => x.Ad).HasMaxLength(50).IsRequired();

            builder.Property(x => x.Soyad).HasMaxLength(50).IsRequired();

            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();

            builder.Property(x => x.TelefonNo).HasMaxLength(50).IsRequired();
        }
    }
}
