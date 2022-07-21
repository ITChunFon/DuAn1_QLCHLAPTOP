using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Db11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KeyCaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKeyCaps = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyCaps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mauSacs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaMau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenMau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mauSacs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sanPhams",
                columns: table => new
                {
                    MaSP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonGiaNhap = table.Column<float>(type: "real", nullable: false),
                    DonGiaBan = table.Column<float>(type: "real", nullable: false),
                    DongSP = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhams", x => x.MaSP);
                });

            migrationBuilder.CreateTable(
                name: "banPhims",
                columns: table => new
                {
                    MaSP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HangSanXuat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KieuKetNoi = table.Column<int>(type: "int", nullable: false),
                    KieuBanPhim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Led = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Layout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KichThuoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrongLuong = table.Column<float>(type: "real", nullable: false),
                    MauSac = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banPhims", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK_banPhims_sanPhams_MaSP",
                        column: x => x.MaSP,
                        principalTable: "sanPhams",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "banPhimKeyCaps",
                columns: table => new
                {
                    IdKeyCaps = table.Column<int>(type: "int", nullable: false),
                    MaSP = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banPhimKeyCaps", x => new { x.IdKeyCaps, x.MaSP });
                    table.ForeignKey(
                        name: "FK_banPhimKeyCaps_banPhims_MaSP",
                        column: x => x.MaSP,
                        principalTable: "banPhims",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_banPhimKeyCaps_KeyCaps_IdKeyCaps",
                        column: x => x.IdKeyCaps,
                        principalTable: "KeyCaps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "banPhimSoLuongSwitches",
                columns: table => new
                {
                    MaSP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Switch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banPhimSoLuongSwitches", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK_banPhimSoLuongSwitches_banPhims_MaSP",
                        column: x => x.MaSP,
                        principalTable: "banPhims",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sanPhamMauSacs",
                columns: table => new
                {
                    IdMau = table.Column<int>(type: "int", nullable: false),
                    MaSP = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhamMauSacs", x => new { x.IdMau, x.MaSP });
                    table.ForeignKey(
                        name: "FK_sanPhamMauSacs_banPhims_MaSP",
                        column: x => x.MaSP,
                        principalTable: "banPhims",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhamMauSacs_mauSacs_IdMau",
                        column: x => x.IdMau,
                        principalTable: "mauSacs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_banPhimKeyCaps_MaSP",
                table: "banPhimKeyCaps",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamMauSacs_MaSP",
                table: "sanPhamMauSacs",
                column: "MaSP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "banPhimKeyCaps");

            migrationBuilder.DropTable(
                name: "banPhimSoLuongSwitches");

            migrationBuilder.DropTable(
                name: "sanPhamMauSacs");

            migrationBuilder.DropTable(
                name: "KeyCaps");

            migrationBuilder.DropTable(
                name: "banPhims");

            migrationBuilder.DropTable(
                name: "mauSacs");

            migrationBuilder.DropTable(
                name: "sanPhams");
        }
    }
}
