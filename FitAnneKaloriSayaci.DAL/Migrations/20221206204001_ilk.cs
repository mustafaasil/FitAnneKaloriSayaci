using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitAnneKaloriSayaci.DAL.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adminler",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adminler", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "date", nullable: false),
                    Boy = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kilo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HamileMi = table.Column<bool>(type: "bit", nullable: false),
                    HamilelikHaftasi = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ogunler",
                columns: table => new
                {
                    OgunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogunler", x => x.OgunId);
                });

            migrationBuilder.CreateTable(
                name: "ProjeYoneticiler",
                columns: table => new
                {
                    ProjeYoneticisiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjeYoneticiler", x => x.ProjeYoneticisiId);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    UrunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kalori = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FotografYolu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrunFotograf = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.UrunId);
                    table.ForeignKey(
                        name: "FK_Urunler_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgunUrun",
                columns: table => new
                {
                    OgunId = table.Column<int>(type: "int", nullable: false),
                    UrunId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgunUrun", x => new { x.OgunId, x.UrunId });
                    table.ForeignKey(
                        name: "FK_OgunUrun_Ogunler_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Ogunler",
                        principalColumn: "OgunId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgunUrun_Urunler_OgunId",
                        column: x => x.OgunId,
                        principalTable: "Urunler",
                        principalColumn: "UrunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YemekRaporlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    OgunID = table.Column<int>(type: "int", nullable: false),
                    UrunID = table.Column<int>(type: "int", nullable: false),
                    Miktar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KaloriToplam = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OlusturulmaTarihi = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YemekRaporlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YemekRaporlar_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YemekRaporlar_Ogunler_OgunID",
                        column: x => x.OgunID,
                        principalTable: "Ogunler",
                        principalColumn: "OgunId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YemekRaporlar_Urunler_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Urunler",
                        principalColumn: "UrunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Adminler",
                columns: new[] { "AdminId", "Email", "Sifre" },
                values: new object[] { 1, "admin", "2" });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "ID", "Ad" },
                values: new object[,]
                {
                    { 1, "İçecekler" },
                    { 2, "Meyveler" },
                    { 3, "Sebzeler" },
                    { 4, "Tatlılar" },
                    { 5, "Yemekler" }
                });

            migrationBuilder.InsertData(
                table: "Kullanicilar",
                columns: new[] { "ID", "Ad", "Boy", "DogumTarihi", "Email", "HamileMi", "HamilelikHaftasi", "Kilo", "Sifre", "Soyad", "TelefonNo" },
                values: new object[,]
                {
                    { 1, "Ayse", 170m, new DateTime(1992, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse@a.com", false, null, 70m, "123456.Aa", "Yılmaz", "(111) 111-1111" },
                    { 2, "Fatma", 200m, new DateTime(1985, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatma@f.com", true, (byte)17, 100m, "123456.Aa", "Özkul", "(222) 222-2222" }
                });

            migrationBuilder.InsertData(
                table: "Ogunler",
                columns: new[] { "OgunId", "Ad" },
                values: new object[,]
                {
                    { 1, "Kahvaltı" },
                    { 2, "Öğle" },
                    { 3, "Ara Öğün" },
                    { 4, "Akşam" }
                });

            migrationBuilder.InsertData(
                table: "ProjeYoneticiler",
                columns: new[] { "ProjeYoneticisiId", "Email", "Sifre" },
                values: new object[] { 1, "projeyoneticisi", "1" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "Ad", "FotografYolu", "Kalori", "KategoriId", "UrunFotograf" },
                values: new object[,]
                {
                    { 1, "Çay", null, 1m, 1, null },
                    { 2, "Kola", null, 37m, 1, null },
                    { 3, "Fanta", null, 48m, 1, null },
                    { 4, "Ayran", null, 40m, 1, null },
                    { 5, "Portakal Suyu", null, 45m, 1, null },
                    { 6, "Vişne", null, 50m, 2, null },
                    { 7, "Armut", null, 57m, 2, null },
                    { 8, "Üzüm", null, 67m, 2, null },
                    { 9, "Şeftali", null, 39m, 2, null },
                    { 10, "Ayva", null, 57m, 2, null },
                    { 11, "Taze Kabak", null, 19m, 3, null },
                    { 12, "Ispanak", null, 23m, 3, null },
                    { 13, "Havuç", null, 41m, 3, null },
                    { 14, "Pırasa", null, 14m, 3, null },
                    { 15, "KarnaBahar", null, 25m, 3, null },
                    { 16, "Revani", null, 348m, 4, null },
                    { 17, "Elmali Kek", null, 301m, 4, null },
                    { 18, "Mozaik Pasta", null, 368m, 4, null },
                    { 19, "Rulo Pasta", null, 179m, 4, null },
                    { 20, "Şöbiyet", null, 326m, 4, null },
                    { 21, "Adana Kebap", null, 361m, 5, null },
                    { 22, "Mantı", null, 170m, 5, null },
                    { 23, "Köfte", null, 168m, 5, null },
                    { 24, "Pide", null, 209m, 5, null },
                    { 25, "Hünkar Beğendi", null, 174m, 5, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OgunUrun_UrunId",
                table: "OgunUrun",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_KategoriId",
                table: "Urunler",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_YemekRaporlar_KullaniciID",
                table: "YemekRaporlar",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_YemekRaporlar_OgunID",
                table: "YemekRaporlar",
                column: "OgunID");

            migrationBuilder.CreateIndex(
                name: "IX_YemekRaporlar_UrunID",
                table: "YemekRaporlar",
                column: "UrunID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adminler");

            migrationBuilder.DropTable(
                name: "OgunUrun");

            migrationBuilder.DropTable(
                name: "ProjeYoneticiler");

            migrationBuilder.DropTable(
                name: "YemekRaporlar");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Ogunler");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
