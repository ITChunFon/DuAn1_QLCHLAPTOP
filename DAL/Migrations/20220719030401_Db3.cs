using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Db3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_nhanViens_MaNV",
                table: "HoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDon",
                table: "HoaDon");

            migrationBuilder.RenameTable(
                name: "HoaDon",
                newName: "hoaDons");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDon_MaNV",
                table: "hoaDons",
                newName: "IX_hoaDons_MaNV");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hoaDons",
                table: "hoaDons",
                column: "MaHD");

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDons_nhanViens_MaNV",
                table: "hoaDons",
                column: "MaNV",
                principalTable: "nhanViens",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hoaDons_nhanViens_MaNV",
                table: "hoaDons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hoaDons",
                table: "hoaDons");

            migrationBuilder.RenameTable(
                name: "hoaDons",
                newName: "HoaDon");

            migrationBuilder.RenameIndex(
                name: "IX_hoaDons_MaNV",
                table: "HoaDon",
                newName: "IX_HoaDon_MaNV");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDon",
                table: "HoaDon",
                column: "MaHD");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_nhanViens_MaNV",
                table: "HoaDon",
                column: "MaNV",
                principalTable: "nhanViens",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
