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
            #endregion







        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //lưu ý chỉ cần thay tên  ở Data Source= tên servername ở máy tính của bạn và phần catalog là tên đb bạn muốn đặt
                optionsBuilder.UseSqlServer("Data Source=TUANANHPC\\SQLEXPRESS01;Initial Catalog=DBDuAn1;Persist Security Info=True;User ID=tuananh;Password=123");
            }
        }
    }
}
