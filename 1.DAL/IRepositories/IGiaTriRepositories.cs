using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface IGiaTriRepositories
    {
        bool Add(GiaTri gt);
        bool Update(GiaTri gt);
        bool Delete(GiaTri gt);
        List<GiaTri> GetGiaTri();
    }
}
