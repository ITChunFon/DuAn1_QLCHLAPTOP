using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class KeyCaps
    {
        public int Id { get; set; }
        public string TenKeyCaps { get; set; }

        public IList<BanPhimKeyCaps> banPhimKeyCaps { get; set; }
    }
}
