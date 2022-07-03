using Microsoft.EntityFrameworkCore.Migrations;

namespace Beltek66.HelloMvc.Migrations
{
    public partial class il : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OgretmenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogretmen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bolum = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmen", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Siniflar",
                columns: table => new
                {
                    Sinifid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sinifad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siniflar", x => x.Sinifid);
                });

            migrationBuilder.CreateTable(
                name: "DersOgretmen",
                columns: table => new
                {
                    DerslerId = table.Column<int>(type: "int", nullable: false),
                    OgretmenlerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersOgretmen", x => new { x.DerslerId, x.OgretmenlerId });
                    table.ForeignKey(
                        name: "FK_DersOgretmen_Dersler_DerslerId",
                        column: x => x.DerslerId,
                        principalTable: "Dersler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DersOgretmen_Ogretmen_OgretmenlerId",
                        column: x => x.OgretmenlerId,
                        principalTable: "Ogretmen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblOgrenciler",
                columns: table => new
                {
                    Ogrenciid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Soyad = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false),
                    Yas = table.Column<byte>(type: "tinyint", nullable: false),
                    Sinifid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOgrenciler", x => x.Ogrenciid);
                    table.ForeignKey(
                        name: "FK_tblOgrenciler_Siniflar_Sinifid",
                        column: x => x.Sinifid,
                        principalTable: "Siniflar",
                        principalColumn: "Sinifid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DersOgretmen_OgretmenlerId",
                table: "DersOgretmen",
                column: "OgretmenlerId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOgrenciler_Sinifid",
                table: "tblOgrenciler",
                column: "Sinifid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DersOgretmen");

            migrationBuilder.DropTable(
                name: "tblOgrenciler");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropTable(
                name: "Ogretmen");

            migrationBuilder.DropTable(
                name: "Siniflar");
        }
    }
}
