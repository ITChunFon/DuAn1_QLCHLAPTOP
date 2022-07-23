using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class SanPham
    {
        public String MaSP { get; set; }
        public string TenSP { get; set; }
        public float DonGiaNhap { get; set; }
        public float DonGiaBan { get; set; }
        public Int32 DongSP { get; set; }
        public string GhiChu { get; set; }

        public SanPham sanPham { get; set; }

        public IList<HoaDonChiTiet> hoaDonChiTiets { get; set; }
    }
}
