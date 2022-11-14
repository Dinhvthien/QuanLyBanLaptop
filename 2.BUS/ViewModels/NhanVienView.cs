using _1.DAL.Models;

namespace _2.BUS.ViewModels
{
    public class NhanVienView
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string MatKhau { get; set; }
        public int TrangThai { get; set; }
        public Guid IdCuaHang { get; set; }
        public Guid IdChucVu { get; set; }
        public virtual CuaHang? CuaHang { get; set; }
        public virtual ChucVu? ChucVu { get; set; }
        public string MaCuaHang { get; set; }
        public string MaChucVu { get; set; }
    }
}
