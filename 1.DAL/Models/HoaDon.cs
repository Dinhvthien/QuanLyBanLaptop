using _1.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class HoaDon
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public DateTime NgayTao { get; set; }
        public string TenNguoiNhan { get; set; }
        public int TinhTrang { get; set; }
        public Guid IdNhanVien { get; set; }
        public Guid IdKhachHang { get; set; }
        public string SdtNguoiNhan { get; set; }
        public Guid IdVoucher { get; set; }
        public virtual NhanVien? NhanVien { get; set; }
        public virtual KhachHang? KhachHang { get; set; }
        public virtual Voucher? Voucher { get; set; }

    }
}
