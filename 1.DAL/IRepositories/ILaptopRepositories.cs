using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface ILaptopRepositories
    {
        bool Add(Laptop lt);
        bool Update(Laptop lt);
        bool Delete(Laptop lt);
        List<Laptop> GetLaptop();

    }
}
