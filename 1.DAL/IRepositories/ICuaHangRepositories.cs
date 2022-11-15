using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface ICuaHangRepositories
    {
        bool Add(CuaHang ch);
        bool Update(CuaHang ch);
        bool Delete(CuaHang ch);
        List<CuaHang> GetCuaHang();
    }
}
