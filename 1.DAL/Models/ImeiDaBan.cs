using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class ImeiDaBan
    {
        public Guid ID { get; set; }
        public Guid IDHoaDonChiTiet { get; set; }
        public string SoEmei { get; set; }
        public virtual HoaDonChiTiet HoaDonChiTiet { get; set; }
    }
}
