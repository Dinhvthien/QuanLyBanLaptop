using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonChiTietRepositories
    {
        bool Add(HoaDonChiTiet hdct);
        bool Update(HoaDonChiTiet hdct);
        bool Delete(HoaDonChiTiet hdct);
        bool UpdateTrangThai(HoaDonChiTiet hdct);
        List<HoaDonChiTiet> GetHoaDonChiTiet();


    }
}
