using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Model;

namespace DAL.DatabaseContext
{
    public class DA1Context : DbContext
    {
        DbSet<NhanVien> nhanViens { get; set; }
        DbSet<HoaDon> hoaDons { get; set; }
        DbSet<KhachHang> khachHangs { get; set; }
        DbSet<HoaDonChiTiet> hoaDonChiTiets { get; set; }
        DbSet<KhuyenMai> khuyenMais { get; set; }
        DbSet<SanPham> sanPhams { get; set; }
        DbSet<BanPhim> banPhims { get; set; }
        DbSet<MauSac> mauSacs { get; set; }
        DbSet<SanPhamMauSac> sanPhamMauSacs { get; set; }
        DbSet<KeyCaps> KeyCaps { get; set; }
        DbSet<BanPhimKeyCaps> banPhimKeyCaps { get; set; }
        DbSet<BanPhimSoLuongSwitch> banPhimSoLuongSwitches { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region nhanvien 
            modelBuilder.Entity<NhanVien>().HasKey(nv => nv.MaNV);
            // tạo quan hệ bảng nhân viên tự trỏ chính nó 
            modelBuilder.Entity<NhanVien>()
                .HasOne(nv => nv.QuanLi)
                .WithMany(nv => nv.nhanViens)
                .HasForeignKey(nv => nv.MaQuanLi);
            // tạo quan hệ với bảng hoá đơn 1 - n
            modelBuilder.Entity<NhanVien>()
                .HasMany<HoaDon>(nv => nv.hoaDons)
                .WithOne(hd => hd.NhanVien)
                .HasForeignKey(hd => hd.MaNV);
            #endregion

            #region HoaDon 
            modelBuilder.Entity<HoaDon>().HasKey(hd => hd.MaHD);
            // tạo quan hệ với bảng hoá đơn chi tiết 1 - n
            modelBuilder.Entity<HoaDon>()
                .HasMany<HoaDonChiTiet>(hd => hd.hoadonchitiets)
                .WithOne(hdct => hdct.hoaDon)
                .HasForeignKey(hdct => hdct.MaHD);
            #endregion

            #region KhachHang
            modelBuilder.Entity<KhachHang>().HasKey(kh => kh.MaKH);
            // tạo quan hệ với bảng hoá đơn 1 - n
            modelBuilder.Entity<KhachHang>()
                .HasMany<HoaDon>(kh => kh.hoaDons)
                .WithOne(hd => hd.khachHang)
                .HasForeignKey(hd => hd.MaKH);
            #endregion

            #region HoaDonChiTiet
            modelBuilder.Entity<HoaDonChiTiet>().HasKey(hdct => new { hdct.MaHD, hdct.MaSP });
            #endregion

            #region KhuyenMai
            modelBuilder.Entity<KhuyenMai>().HasKey(km => km.MaKM);
            // tạo quan hệ với bảng hoá đơn 1 - n
            modelBuilder.Entity<KhuyenMai>()
                .HasMany<HoaDon>(km => km.hoaDons)
                .WithOne(hd => hd.khuyenMai)
                .HasForeignKey(hd => hd.MaKM);
            // tạo quan hệ với bảng sản phầm 1 - 1

            #endregion

            #region BanPhim
            modelBuilder.Entity<BanPhim>().HasKey(bp => bp.MaSP);
            // tạo quan hệ với bảng BanPhimSoLuongSwitch 1 - n
            modelBuilder.Entity<BanPhim>()
                .HasMany<BanPhimSoLuongSwitch>(bp => bp.banPhimSoLuongSwitches)
                .WithOne(bpsls => bpsls.banPhim)
                .HasForeignKey(bpsls => bpsls.MaSP);
            // tạo quan hệ 1 - n với bảng BanPhimKeyCaps
            modelBuilder.Entity<BanPhim>()
                .HasMany<BanPhimKeyCaps>(bp => bp.banPhimKeyCaps)
                .WithOne(bpkcs => bpkcs.banPhim)
                .HasForeignKey(bpkcs => bpkcs.MaSP);
            // tạo quan hệ 1 - n với bảng sanphammausac
            modelBuilder.Entity<BanPhim>()
                .HasMany<SanPhamMauSac>(bp => bp.sanPhamMauSacs)
                .WithOne(spms => spms.banPhim)
                .HasForeignKey(spms => spms.MaSP);
            #endregion

            #region SanPham
            modelBuilder.Entity<SanPham>().HasKey(sp => sp.MaSP);
            // tạo quan hệ với bảng bàn phím 1 - 1
            modelBuilder.Entity<SanPham>()
                .HasOne<BanPhim>(sp => sp.banPhims)
                .WithOne(bp => bp.sanPham)
                .HasForeignKey<BanPhim>(bp => bp.MaSP);
            // tạo quan 1 - n với bảng hoadonchitiet
            modelBuilder.Entity<SanPham>()
                .HasMany<HoaDonChiTiet>(sp => sp.hoaDonChiTiets)
                .WithOne(hdct => hdct.sanPham)
                .HasForeignKey(hdct => hdct.MaSP);
            #endregion

            #region KeyCaps
            modelBuilder.Entity<KeyCaps>().HasKey(kcs => kcs.Id);
            // tạo quan hệ 1 - n với bảng BanPhimKeyCaps
            modelBuilder.Entity<KeyCaps>()
                .HasMany<BanPhimKeyCaps>(kcs => kcs.banPhimKeyCaps)
                .WithOne(bpkcs => bpkcs.keyCaps)
                .HasForeignKey(bpkcs => bpkcs.IdKeyCaps);
            #endregion

            #region MauSac
            modelBuilder.Entity<MauSac>().HasKey(ms => ms.Id);
            // tạo quan hệ 1 - n với bảng sanphammausac
            modelBuilder.Entity<MauSac>()
                .HasMany<SanPhamMauSac>(ms => ms.sanPhamMauSacs)
                .WithOne(spms => spms.mauSac)
                .HasForeignKey(spms => spms.IdMau);
            #endregion

            #region BanPhimKeyCaps
            modelBuilder.Entity<BanPhimKeyCaps>().HasKey(bpkcs => new { bpkcs.IdKeyCaps, bpkcs.MaSP });
            #endregion

            #region BanPhimSoLuongSwitch
            modelBuilder.Entity<BanPhimSoLuongSwitch>().HasKey(bpsls => bpsls.MaSP);
            #endregion

            #region SanPhamMauSac 
            modelBuilder.Entity<SanPhamMauSac>().HasKey(spms => new { spms.IdMau, spms.MaSP });
            #endregion
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //lưu ý chỉ cần thay tên  ở Data Source= tên servername ở máy tính của bạn và phần catalog là tên đb bạn muốn đặt
                optionsBuilder.UseSqlServer("Data Source=TUANANHPC\\SQLEXPRESS01;Initial Catalog=DBDuAn1;Persist Security Info=True;User ID=tuananh;Password=123");

                // mn thay đổi chạy rồi comment lại nhé cho đỡ lỗi 

                //optionsBuilder.UseSqlServer("Data Source=TUANANHPC\\SQLEXPRESS01;Initial Catalog=DBDuAn1;Persist Security Info=True;User ID=tuananh;Password=123");

                //optionsBuilder.UseSqlServer("Data Source=TUANANHPC\\SQLEXPRESS01;Initial Catalog=DBDuAn1;Persist Security Info=True;User ID=tuananh;Password=123");

                //optionsBuilder.UseSqlServer("Datak Source=TUANANHPC\\SQLEXPRESS01;Initial Catalog=DBDuAn1;Persist Security Info=True;User ID=tuananh;Password=123");


            }
        }
    }
}
