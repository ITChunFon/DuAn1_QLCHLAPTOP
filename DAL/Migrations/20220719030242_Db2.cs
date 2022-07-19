using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class Db2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayLapHD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HinhThucThanhToan = table.Column<int>(type: "int", nullable: false),
                    HinhThucGiaoHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TienKhachDua = table.Column<float>(type: "real", nullable: false),
                    TienTraLai = table.Column<float>(type: "real", nullable: false),
                    TongTienHD = table.Column<float>(type: "real", nullable: false),
                    NguoiLapHD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaKH = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_nhanViens_MaNV",
                        column: x => x.MaNV,
                        principalTable: "nhanViens",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaNV",
                table: "HoaDon",
                column: "MaNV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDon");
        }
    }
}
