using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class NsxRepositories : INsxRepositories
    {
        BanHangDbContext context = new BanHangDbContext();

        public bool Add(Nsx nsx)
        {
            if (nsx == null) return false;
            context.NSXs.Add(nsx);
            context.SaveChanges();
            return true;
        }

        public bool Delete(Nsx nsx)
        {
            if (nsx == null) return false;
            var t = context.NSXs.Find(nsx.ID);
            context.Remove(t);
            context.SaveChanges();
            return true;
        }

        public List<Nsx> GetNsx()
        {
            return context.NSXs.ToList();
        }

        public bool Update(Nsx nsx)
        {
            if (nsx == null) return false;
            var t = context.NSXs.Find(nsx.ID);
            t.Ten = nsx.Ten;
            context.Update(t);
            context.SaveChanges();
            return true;
        }
    }
}
