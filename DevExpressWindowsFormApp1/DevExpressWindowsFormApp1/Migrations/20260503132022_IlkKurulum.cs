using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DevExpressWindowsFormApp1.Migrations
{
    public partial class IlkKurulum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(nullable: true),
                    EPosta = table.Column<string>(nullable: true),
                    Sifre = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullanicilar");
        }
    }
}
