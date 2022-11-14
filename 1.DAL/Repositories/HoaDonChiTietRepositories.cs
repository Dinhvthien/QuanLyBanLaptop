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
            var t = context.HoaDonChiTiets.FirstOrDefault(a => a.IDHoaDon == hdct.IDHoaDon && a.IDChiTietLapTop == hdct.IDChiTietLapTop);
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
            var t = context.HoaDonChiTiets.FirstOrDefault(a => a.IDHoaDon == hdct.IDHoaDon && a.IDChiTietLapTop == hdct.IDChiTietLapTop);
            t.SoLuong = hdct.SoLuong;
            t.GiaTruoc = hdct.GiaTruoc;
            t.NgayTao = hdct.NgayTao;
            t.GiaSauKhiGiam = hdct.GiaSauKhiGiam;
            context.Update(t);
            context.SaveChanges();
            return true;
        }
    }
}
