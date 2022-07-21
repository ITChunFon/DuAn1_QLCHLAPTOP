using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Db8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MaHD",
                table: "hoaDonChiTiets",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hoaDonChiTiets",
                table: "hoaDonChiTiets",
                column: "MaHD");

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDonChiTiets_hoaDons_MaHD",
                table: "hoaDonChiTiets",
                column: "MaHD",
                principalTable: "hoaDons",
                principalColumn: "MaHD",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hoaDonChiTiets_hoaDons_MaHD",
                table: "hoaDonChiTiets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hoaDonChiTiets",
                table: "hoaDonChiTiets");

            migrationBuilder.AlterColumn<string>(
                name: "MaHD",
                table: "hoaDonChiTiets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
