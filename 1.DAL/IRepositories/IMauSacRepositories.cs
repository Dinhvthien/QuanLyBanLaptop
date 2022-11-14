using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface IMauSacRepositories
    {
        bool Add(MauSac ms);
        bool Update(MauSac ms);
        bool Delete(MauSac ms);
        List<MauSac> GetMauSac();
    }
}
