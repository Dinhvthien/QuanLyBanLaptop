using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface IThuocTinhRepositories
    {
        bool Add(ThuocTinh tt);
        bool Update(ThuocTinh tt);
        bool Delete(ThuocTinh tt);
        List<ThuocTinh> GetThuocTinh();
    }
}
