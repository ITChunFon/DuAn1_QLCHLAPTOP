using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class HoaDonChiTiet
    {
        public string MaHD { get; set; }
        public HoaDon hoaDon { get; set; }

        public string MaSP { get; set; }
        public SanPham sanPham { get; set; }

        public int SoLuongMua { get; set; }
        //public float DonGia { get; set; }

    }
}
