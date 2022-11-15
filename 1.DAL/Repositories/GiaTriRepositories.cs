using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class GiaTriRepositories : IGiaTriRepositories
    {
        BanHangDbContext context = new BanHangDbContext();
        public bool Add(GiaTri gt)
        {
            if (gt == null) return false;
            context.GiaTris.Add(gt);
            context.SaveChanges();
            return true;
        }

        public bool Delete(GiaTri gt)
        {
            if (gt == null) return false;
            var x = context.GiaTris.FirstOrDefault(a => a.ID == gt.ID);
            context.Remove(x);
            context.SaveChanges();
            return true;
        }

        public List<GiaTri> GetGiaTri()
        {
            return context.GiaTris.ToList();
        }

        public bool Update(GiaTri gt)
        {
            if (gt == null) return false;
            var x = context.GiaTris.FirstOrDefault(a => a.ID == gt.ID);
            x.ThongSo = gt.ThongSo;
            context.Update(x);
            context.SaveChanges();
            return true;
        }
    }
}
