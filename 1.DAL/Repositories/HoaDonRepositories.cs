using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class HoaDonRepositories : IHoaDonRepositories
    {
        BanHangDbContext context = new BanHangDbContext();
        public bool Add(HoaDon hd)
        {
            if (hd == null) return false;
            context.HoaDons.Add(hd);
            context.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon hd)
        {
            if (hd == null) return false;
            var t = context.HoaDons.Find(hd.ID);
            context.Remove(t);
            context.SaveChanges();
            return true;
        }

        public List<HoaDon> GetHoaDon()
        {
            return context.HoaDons.ToList();
        }

        public bool Update(HoaDon hd)
        {
            if (hd == null) return false;
            var t = context.HoaDons.Find(hd.ID);
            t.TenNguoiNhan = hd.TenNguoiNhan;
            t.TinhTrang = hd.TinhTrang;
            t.SdtNguoiNhan = hd.SdtNguoiNhan;
            context.Update(t);
            context.SaveChanges();
            return true;
        }
    }
}
