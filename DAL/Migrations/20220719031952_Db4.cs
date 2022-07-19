using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Db4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MaKH",
                table: "hoaDons",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "khachHangs",
                columns: table => new
                {
                    MaKH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHangs", x => x.MaKH);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_MaKH",
                table: "hoaDons",
                column: "MaKH");

            migrationBuilder.AddForeignKey(
                name: "FK_hoaDons_khachHangs_MaKH",
                table: "hoaDons",
                column: "MaKH",
                principalTable: "khachHangs",
                principalColumn: "MaKH",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_hoaDons_khachHangs_MaKH",
                table: "hoaDons");

            migrationBuilder.DropTable(
                name: "khachHangs");

            migrationBuilder.DropIndex(
                name: "IX_hoaDons_MaKH",
                table: "hoaDons");

            migrationBuilder.AlterColumn<string>(
                name: "MaKH",
                table: "hoaDons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
