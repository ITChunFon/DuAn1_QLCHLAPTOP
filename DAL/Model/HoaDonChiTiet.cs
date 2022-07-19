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
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }

        public HoaDon hoaDon { get; set; }
    }
}
