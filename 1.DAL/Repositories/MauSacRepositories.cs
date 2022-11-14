using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class MauSacRepositories : IMauSacRepositories
    {
        BanHangDbContext context = new BanHangDbContext();
        public bool Add(MauSac ms)
        {
            if (ms == null) return false;
            context.MauSacs.Add(ms);
            context.SaveChanges();
            return true;
        }

        public bool Delete(MauSac ms)
        {
            if (ms == null) return false;
            var t = context.MauSacs.Find(ms.ID);
            context.Remove(t);
            context.SaveChanges();
            return true;
        }

        public List<MauSac> GetMauSac()
        {
            return context.MauSacs.ToList();
        }

        public bool Update(MauSac ms)
        {
            if (ms == null) return false;
            var t = context.MauSacs.Find(ms.ID);
            t.Ten = ms.Ten;
            context.Update(t);
            context.SaveChanges();
            return true;
        }
    }

}
