using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class CuaHangRepositories : ICuaHangRepositories
    {
        BanHangDbContext context = new BanHangDbContext();
        public bool Add(CuaHang ch)
        {
            if (ch == null) return false;
            context.CuaHangs.Add(ch);
            context.SaveChanges();
            return true;
        }

        public bool Delete(CuaHang ch)
        {
            if (ch == null) return false;
            var thao = context.CuaHangs.FirstOrDefault(a => a.ID == ch.ID);
            //var thao = context.KhachHangs.Find(kh.Id);
            context.Remove(thao);
            context.SaveChanges();
            return true;
        }

        public List<CuaHang> GetCuaHang()
        {
            return context.CuaHangs.ToList();
        }

        public bool Update(CuaHang ch)
        {
            if (ch == null) return false;
            var thao = context.CuaHangs.FirstOrDefault(a => a.ID == ch.ID);
            //var thao = context.KhachHangs.Find(kh.Id);
            thao.Ten = ch.Ten;
            // thao.Ma = ch.Ma;// ko cho sửa mã
            thao.DiaChi = ch.DiaChi;
            thao.Sdt = ch.Sdt;
            context.Update(thao);
            context.SaveChanges();
            return true;
        }
    }
}
