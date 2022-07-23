using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class SanPhamMauSac
    {
        public int IdMau { get; set; }
        public MauSac mauSac { get; set; }

        public string MaSP { get; set; }
        public BanPhim banPhim { get; set; }
    }
}
