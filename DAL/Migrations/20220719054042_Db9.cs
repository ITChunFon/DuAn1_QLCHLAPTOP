using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Db9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaKM",
                table: "hoaDonChiTiets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_MaKM",
                table: "hoaDonChiTiets",
                column: "MaKM");

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDonChiTiets_khuyenMais_MaKM",
                table: "hoaDonChiTiets",
                column: "MaKM",
                principalTable: "khuyenMais",
                principalColumn: "MaKM",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hoaDonChiTiets_khuyenMais_MaKM",
                table: "hoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "khuyenMais");

            migrationBuilder.DropIndex(
                name: "IX_hoaDonChiTiets_MaKM",
                table: "hoaDonChiTiets");

            migrationBuilder.DropColumn(
                name: "MaKM",
                table: "hoaDonChiTiets");
        }
    }
}
