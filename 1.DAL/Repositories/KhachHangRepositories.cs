using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class KhachHangRepositories : IKhachHangRepositories
    {
        BanHangDbContext context = new BanHangDbContext();
        public bool Add(KhachHang kh)
        {
            if (kh == null) return false;
            context.KhachHangs.Add(kh);
            context.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang kh)
        {
            if (kh == null) return false;
            var t = context.KhachHangs.FirstOrDefault(a => a.ID == kh.ID);
            context.Remove(t);
            context.SaveChanges();
            return true;
        }

        public List<KhachHang> GetKhachHang()
        {
            return context.KhachHangs.ToList();
        }

        public bool Update(KhachHang kh)
        {
            if (kh == null) return false;
            var t = context.KhachHangs.FirstOrDefault(a => a.ID == kh.ID);
            t.HoTen = kh.HoTen;
            t.DiaChi = kh.DiaChi;
            context.Update(t);
            context.SaveChanges();
            return true;
        }
    }
}
