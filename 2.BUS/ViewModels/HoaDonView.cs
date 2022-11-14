using _1.DAL.Models;

namespace _2.BUS.ViewModels
{
    public class HoaDonView
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
        public string MaNhanVien { get; set; }
        public string MaKhachHang { get; set; }
        public string MaVoucher { get; set; }
    }
}
