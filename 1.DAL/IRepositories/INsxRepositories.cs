using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface INsxRepositories
    {
        bool Add(Nsx nsx);
        bool Update(Nsx nsx);
        bool Delete(Nsx nsx);
        List<Nsx> GetNsx();
    }
}
