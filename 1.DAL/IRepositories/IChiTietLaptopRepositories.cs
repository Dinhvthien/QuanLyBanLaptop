using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface IChiTietLaptopRepositories
    {
        bool Add(ChiTietLaptop ctlt);
        bool Update(ChiTietLaptop ctlt);
        bool Delete(ChiTietLaptop ctlt);
        List<ChiTietLaptop> GetChiTietLaptop();
    }
}
