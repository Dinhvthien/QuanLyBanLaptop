using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class NhanVienRepositories : INhanVienRepositories
    {
        BanHangDbContext context = new BanHangDbContext();

        public bool Add(NhanVien nv)
        {
            if (nv == null) return false;
            context.NhanViens.Add(nv);
            context.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien nv)
        {
            if (nv == null) return false;
            var vina = context.NhanViens.FirstOrDefault(a => a.ID == nv.ID);
            context.Remove(vina);
            context.SaveChanges();
            return true;
        }

        public List<NhanVien> GetNhanVien()
        {
            return context.NhanViens.ToList();
        }

        public bool Update(NhanVien nv)
        {
            if (nv == null) return false;
            var vina = context.NhanViens.FirstOrDefault(a => a.ID == nv.ID);
            vina.HoTen = nv.HoTen;
            vina.DiaChi = nv.DiaChi;
            vina.SDT = nv.SDT;
            vina.MatKhau = nv.MatKhau;
            vina.TrangThai = nv.TrangThai;

            context.Update(vina);
            context.SaveChanges();
            return true;
        }
    }
}
