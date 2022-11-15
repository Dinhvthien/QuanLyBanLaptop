using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface IChucVuRepositories
    {
        bool Add(ChucVu cv);
        bool Update(ChucVu cv);
        bool Delete(ChucVu cv);
        List<ChucVu> GetChucVu();
    }
}
