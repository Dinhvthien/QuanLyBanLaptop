using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class LaptopRepositories : ILaptopRepositories
    {
        BanHangDbContext context = new BanHangDbContext();
        public bool Add(Laptop lt)
        {
            if (lt == null) return false;
            context.LapTops.Add(lt);
            context.SaveChanges();
            return true;
        }

        public bool Delete(Laptop lt)
        {
            if (lt == null) return false;
            var t = context.LapTops.Find(lt.ID);
            context.Remove(t);
            context.SaveChanges();
            return true;
        }

        public List<Laptop> GetLaptop()
        {
            return context.LapTops.ToList();
        }

        public bool Update(Laptop lt)
        {
            if (lt == null) return false;
            var t = context.LapTops.Find(lt.ID);
            t.Ten = lt.Ten;
            context.Update(t);
            context.SaveChanges();
            return true;
        }
    }
}
