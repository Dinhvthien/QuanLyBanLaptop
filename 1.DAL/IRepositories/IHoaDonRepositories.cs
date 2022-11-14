using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonRepositories
    {
        bool Add(HoaDon hd);
        bool Update(HoaDon hd);
        bool Delete(HoaDon hd);
        List<HoaDon> GetHoaDon();
    }
}
