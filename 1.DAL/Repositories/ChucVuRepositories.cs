using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class ChucVuRepositories : IChucVuRepositories
    {
        BanHangDbContext context = new BanHangDbContext();
        public bool Add(ChucVu cv)
        {
            if (cv == null) return false;
            context.ChucVus.Add(cv);
            context.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu cv)
        {
            if (cv == null) return false;
            var thao = context.ChucVus.FirstOrDefault(a => a.ID == cv.ID);
            context.Remove(thao);
            context.SaveChanges();
            return true;
        }

        public List<ChucVu> GetChucVu()
        {
            return context.ChucVus.ToList();
        }

        public bool Update(ChucVu cv)
        {
            if (cv == null) return false;
            var thao = context.ChucVus.FirstOrDefault(a => a.ID == cv.ID);
            thao.Ten = cv.Ten;
            context.Update(thao);
            context.SaveChanges();
            return true;
        }
    }
}
