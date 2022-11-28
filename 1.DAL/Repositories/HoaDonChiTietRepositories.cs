using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class HoaDonChiTietRepositories : IHoaDonChiTietRepositories
    {
        BanHangDbContext context = new BanHangDbContext();
        public bool Add(HoaDonChiTiet hdct)
        {
            if (hdct == null) return false;
            context.HoaDonChiTiets.Add(hdct);
            context.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet hdct)
        {
            if (hdct == null) return false;
            var t = context.HoaDonChiTiets.Find(hdct.ID);
            context.Remove(t);
            context.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetHoaDonChiTiet()
        {
            return context.HoaDonChiTiets.ToList();
        }

        public bool Update(HoaDonChiTiet hdct)
        {
            if (hdct == null) return false;
            var t = context.HoaDonChiTiets.Find(hdct.ID);
            t.SoLuong = hdct.SoLuong;
            t.GiaTruoc = hdct.GiaTruoc;
            t.GiaSauKhiGiam = hdct.GiaSauKhiGiam;
            t.TinhTrang = hdct.TinhTrang;
            context.Update(t);
            context.SaveChanges();
            return true;
        }
       public bool UpdateTrangThai(HoaDonChiTiet hdct)
        {
            if (hdct == null) return false;
            var t = context.HoaDonChiTiets.Find(hdct.ID);
      
            t.TinhTrang = hdct.TinhTrang;
            context.Update(t);
            context.SaveChanges();
            return true;
        }
    }
}
