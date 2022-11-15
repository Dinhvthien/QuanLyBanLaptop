using _1.DAL.Models;

namespace _2.BUS.ViewModels
{
    public class HoaDonChiTietView
    {
        public Guid IDHoaDon { get; set; }
        public Guid IDChiTietLapTop { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaTruoc { get; set; }
        public DateTime NgayTao { get; set; }
        public decimal GiaSauKhiGiam { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual ChiTietLaptop ChiTietLaptop { get; set; }
    }
}
