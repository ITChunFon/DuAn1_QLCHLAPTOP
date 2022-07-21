using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Db10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hoaDonChiTiets_khuyenMais_MaKM",
                table: "hoaDonChiTiets");

            migrationBuilder.DropIndex(
                name: "IX_hoaDonChiTiets_MaKM",
                table: "hoaDonChiTiets");

            migrationBuilder.DropColumn(
                name: "MaKM",
                table: "hoaDonChiTiets");

            migrationBuilder.AddColumn<string>(
                name: "MaKM",
                table: "hoaDons",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_MaKM",
                table: "hoaDons",
                column: "MaKM");

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
                name: "FK_hoaDons_khuyenMais_MaKM",
                table: "hoaDons");

            migrationBuilder.DropIndex(
                name: "IX_hoaDons_MaKM",
                table: "hoaDons");

            migrationBuilder.DropColumn(
                name: "MaKM",
                table: "hoaDons");

            migrationBuilder.AddColumn<string>(
                name: "MaKM",
                table: "hoaDonChiTiets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

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
    }
}
