using DAL.DatabaseContext;
using DAL.IRepository;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class KhachHangRepository : IKhachHangRepository
    {
        private DatabaseContext.DA1Context _DA1context;
        private List<KhachHang> _lstKhachHang;
        public KhachHangRepository()
        {
            _lstKhachHang = new List<KhachHang>();
            _DA1context = new DatabaseContext.DA1Context();
            LayDanhSachKhachHang();
        }
        public List<KhachHang> LayDanhSachKhachHang()
        {
            _lstKhachHang = _DA1context.khachHangs.ToList();
            return _lstKhachHang;
        }
    }
}
