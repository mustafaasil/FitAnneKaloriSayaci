using FitAnneKaloriSayaci.DAL.Configuration;
using FitAnneKaloriSayaci.DATA.Siniflar;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FitAnneKaloriSayaci.DAL.Context
{
    public class ProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=FitAnneDb;integrated security=true;");
        }

        public DbSet<Kullanici> Kullanicilar => Set<Kullanici>();

        public DbSet<Admin> Adminler => Set<Admin>();

        public DbSet<ProjeYoneticisi> ProjeYoneticiler => Set<ProjeYoneticisi>();

        public DbSet<Urun> Urunler => Set<Urun>();

        public DbSet<Ogun> Ogunler => Set<Ogun>();

        public DbSet<Kategori> Kategoriler => Set<Kategori>();

        public DbSet<YemekRapor> YemekRaporlar => Set<YemekRapor>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>().HasData(new Admin
            {
                AdminId = 1,
                Email = "admin",
                Sifre = "2"
            });

            modelBuilder.Entity<ProjeYoneticisi>().HasData(new ProjeYoneticisi
            {
                ProjeYoneticisiId = 1,
                Email = "projeyoneticisi",
                Sifre = "1"
            });

            modelBuilder.Entity<Kullanici>().HasData(
            new Kullanici
            {
                ID = 1,
                Ad = "Ayse",
                Soyad = "Yılmaz",
                Boy = 170,
                Kilo = 70,
                Email = "ayse@a.com",
                Sifre = "123456.Aa",
                TelefonNo = "(111) 111-1111",
                DogumTarihi = new DateTime(1992, 5, 29),
                HamileMi = false
            },
            new Kullanici
            {
                ID = 2,
                Ad = "Fatma",
                Soyad = "Özkul",
                Boy = 200,
                Kilo = 100,
                Email = "fatma@f.com",
                Sifre = "123456.Aa",
                TelefonNo = "(222) 222-2222",
                DogumTarihi = new DateTime(1985, 9, 17),
                HamileMi = true,
                HamilelikHaftasi = 17
            });

            modelBuilder.Entity<Kategori>().HasData(
                new Kategori { ID = 1, Ad = "İçecekler" },
                new Kategori { ID = 2, Ad = "Meyveler" },
                new Kategori { ID = 3, Ad = "Sebzeler" },
                new Kategori { ID = 4, Ad = "Tatlılar" },
                new Kategori { ID = 5, Ad = "Yemekler" }
                );

            modelBuilder.Entity<Urun>().HasData(
                new Urun { UrunId = 1, Ad = "Çay", Kalori = 1, KategoriId = 1 },
                new Urun { UrunId = 2, Ad = "Kola", Kalori = 37, KategoriId = 1 },
                new Urun { UrunId = 3, Ad = "Fanta", Kalori = 48, KategoriId = 1 },
                new Urun { UrunId = 4, Ad = "Ayran", Kalori = 40, KategoriId = 1 },
                new Urun { UrunId = 5, Ad = "Portakal Suyu", Kalori = 45, KategoriId = 1 },
                new Urun { UrunId = 6, Ad = "Vişne", Kalori = 50, KategoriId = 2 },
                new Urun { UrunId = 7, Ad = "Armut", Kalori = 57, KategoriId = 2 },
                new Urun { UrunId = 8, Ad = "Üzüm", Kalori = 67, KategoriId = 2 },
                new Urun { UrunId = 9, Ad = "Şeftali", Kalori = 39, KategoriId = 2 },
                new Urun { UrunId = 10, Ad = "Ayva", Kalori = 57, KategoriId = 2 },
                new Urun { UrunId = 11, Ad = "Taze Kabak", Kalori = 19, KategoriId = 3 },
                new Urun { UrunId = 12, Ad = "Ispanak", Kalori = 23, KategoriId = 3 },
                new Urun { UrunId = 13, Ad = "Havuç", Kalori = 41, KategoriId = 3 },
                new Urun { UrunId = 14, Ad = "Pırasa", Kalori = 14, KategoriId = 3 },
                new Urun { UrunId = 15, Ad = "KarnaBahar", Kalori = 25, KategoriId = 3 },
                new Urun { UrunId = 16, Ad = "Revani", Kalori = 348, KategoriId = 4 },
                new Urun { UrunId = 17, Ad = "Elmali Kek", Kalori = 301, KategoriId = 4 },
                new Urun { UrunId = 18, Ad = "Mozaik Pasta", Kalori = 368, KategoriId = 4 },
                new Urun { UrunId = 19, Ad = "Rulo Pasta", Kalori = 179, KategoriId = 4 },
                new Urun { UrunId = 20, Ad = "Şöbiyet", Kalori = 326, KategoriId = 4 },
                new Urun { UrunId = 21, Ad = "Adana Kebap", Kalori = 361, KategoriId = 5 },
                new Urun { UrunId = 22, Ad = "Mantı", Kalori = 170, KategoriId = 5 },
                new Urun { UrunId = 23, Ad = "Köfte", Kalori = 168, KategoriId = 5 },
                new Urun { UrunId = 24, Ad = "Pide", Kalori = 209, KategoriId = 5 },
                new Urun { UrunId = 25, Ad = "Hünkar Beğendi", Kalori = 174, KategoriId = 5 
                });

            modelBuilder.Entity<Ogun>().HasData(
                new Ogun { OgunId = 1, Ad = "Kahvaltı" },
                new Ogun { OgunId = 2, Ad = "Öğle" },
                new Ogun { OgunId = 3, Ad = "Ara Öğün" },
                new Ogun { OgunId = 4, Ad = "Akşam" }
                );


            modelBuilder.Entity<Urun>().HasOne(urun => urun.Kategori).WithMany(kategori => kategori.Urunler).HasForeignKey(fk => fk.KategoriId);
            //Bire çok bağlantı için gerekli yapılandırma

            modelBuilder.Entity<YemekRapor>().Property(x => x.OlusturulmaTarihi).HasColumnType("date");

            modelBuilder.Entity<ProjeYoneticisi>().Property(x => x.Email).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Admin>().Property(x => x.Email).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Kategori>().Property(x => x.Ad).HasMaxLength(50).IsRequired();


            modelBuilder.ApplyConfiguration(new KullaniciConfiguration());
            modelBuilder.ApplyConfiguration(new OgunUrunConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }


}
