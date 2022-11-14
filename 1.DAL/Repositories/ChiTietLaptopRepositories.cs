using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class ChiTietLaptopRepositories : IChiTietLaptopRepositories
    {
        BanHangDbContext context = new BanHangDbContext();
        public bool Add(ChiTietLaptop ctlt)
        {
            if (ctlt == null) return false;
            context.ChiTietLapTops.Add(ctlt);
            context.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietLaptop ctlt)
        {
            if (ctlt == null) return false;
            var t = context.ChiTietLapTops.Find(ctlt.ID);
            context.Remove(t);
            context.SaveChanges();
            return true;
        }

        public List<ChiTietLaptop> GetChiTietLaptop()
        {
            return context.ChiTietLapTops.ToList();
        }

        public bool Update(ChiTietLaptop ctlt)
        {
            if (ctlt == null) return false;
            var t = context.ChiTietLapTops.Find(ctlt.ID);
            t.MoTa = ctlt.MoTa;
            t.SoLuong = ctlt.SoLuong;
            t.GiaNhap = ctlt.GiaNhap;
            t.Giaban = ctlt.Giaban;
            context.Update(t);
            context.SaveChanges();
            return true;
        }
    }
}
