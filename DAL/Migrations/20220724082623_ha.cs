using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class ha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_hoaDonChiTiets",
                table: "hoaDonChiTiets");

            migrationBuilder.DropColumn(
                name: "DonGia",
                table: "hoaDonChiTiets");

            migrationBuilder.DropColumn(
                name: "TenSP",
                table: "hoaDonChiTiets");

            migrationBuilder.RenameColumn(
                name: "SoLuong",
                table: "hoaDonChiTiets",
                newName: "SoLuongMua");

            migrationBuilder.AddColumn<string>(
                name: "MaKM",
                table: "hoaDons",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaSP",
                table: "hoaDonChiTiets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hoaDonChiTiets",
                table: "hoaDonChiTiets",
                columns: new[] { "MaHD", "MaSP" });

            migrationBuilder.CreateTable(
                name: "keyCaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKeyCaps = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_keyCaps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "khuyenMais",
                columns: table => new
                {
                    MaKM = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKhuyenMai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChietKhau = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khuyenMais", x => x.MaKM);
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
                        name: "FK_banPhimKeyCaps_keyCaps_IdKeyCaps",
                        column: x => x.IdKeyCaps,
                        principalTable: "keyCaps",
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
                    table.PrimaryKey("PK_sanPhamMauSacs", x => new { x.MaSP, x.IdMau });
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
                name: "IX_hoaDons_MaKM",
                table: "hoaDons",
                column: "MaKM");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_MaSP",
                table: "hoaDonChiTiets",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_banPhimKeyCaps_MaSP",
                table: "banPhimKeyCaps",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhamMauSacs_IdMau",
                table: "sanPhamMauSacs",
                column: "IdMau");

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDonChiTiets_sanPhams_MaSP",
                table: "hoaDonChiTiets",
                column: "MaSP",
                principalTable: "sanPhams",
                principalColumn: "MaSP",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDons_khuyenMais_MaKM",
                table: "hoaDons",
                column: "MaKM",
                principalTable: "khuyenMais",
                principalColumn: "MaKM");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hoaDonChiTiets_sanPhams_MaSP",
                table: "hoaDonChiTiets");

            migrationBuilder.DropForeignKey(
                name: "FK_hoaDons_khuyenMais_MaKM",
                table: "hoaDons");

            migrationBuilder.DropTable(
                name: "banPhimKeyCaps");

            migrationBuilder.DropTable(
                name: "banPhimSoLuongSwitches");

            migrationBuilder.DropTable(
                name: "khuyenMais");

            migrationBuilder.DropTable(
                name: "sanPhamMauSacs");

            migrationBuilder.DropTable(
                name: "keyCaps");

            migrationBuilder.DropTable(
                name: "banPhims");

            migrationBuilder.DropTable(
                name: "mauSacs");

            migrationBuilder.DropTable(
                name: "sanPhams");

            migrationBuilder.DropIndex(
                name: "IX_hoaDons_MaKM",
                table: "hoaDons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hoaDonChiTiets",
                table: "hoaDonChiTiets");

            migrationBuilder.DropIndex(
                name: "IX_hoaDonChiTiets_MaSP",
                table: "hoaDonChiTiets");

            migrationBuilder.DropColumn(
                name: "MaKM",
                table: "hoaDons");

            migrationBuilder.DropColumn(
                name: "MaSP",
                table: "hoaDonChiTiets");

            migrationBuilder.RenameColumn(
                name: "SoLuongMua",
                table: "hoaDonChiTiets",
                newName: "SoLuong");

            migrationBuilder.AddColumn<float>(
                name: "DonGia",
                table: "hoaDonChiTiets",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "TenSP",
                table: "hoaDonChiTiets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hoaDonChiTiets",
                table: "hoaDonChiTiets",
                column: "MaHD");
        }
    }
}
