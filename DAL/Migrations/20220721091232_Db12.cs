using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Db12 : Migration
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
                name: "MaSP",
                table: "hoaDonChiTiets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hoaDonChiTiets",
                table: "hoaDonChiTiets",
                columns: new[] { "MaHD", "MaSP" });

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_MaSP",
                table: "hoaDonChiTiets",
                column: "MaSP");

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDonChiTiets_sanPhams_MaSP",
                table: "hoaDonChiTiets",
                column: "MaSP",
                principalTable: "sanPhams",
                principalColumn: "MaSP",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hoaDonChiTiets_sanPhams_MaSP",
                table: "hoaDonChiTiets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hoaDonChiTiets",
                table: "hoaDonChiTiets");

            migrationBuilder.DropIndex(
                name: "IX_hoaDonChiTiets_MaSP",
                table: "hoaDonChiTiets");

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
