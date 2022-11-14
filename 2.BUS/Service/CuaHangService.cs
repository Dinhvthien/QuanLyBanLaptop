using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class CuaHangService : ICuaHangService
    {
        ICuaHangRepositories cuaHangRepositories = new CuaHangRepositories();
        public string Add(CuaHangView chv)
        {
            if (chv == null) return "Thất Bại";
            CuaHang thao = new CuaHang();
            thao.ID = chv.ID;
            thao.Ten = chv.Ten;
            thao.Ma = chv.Ma;
            thao.DiaChi = chv.DiaChi;
            thao.Sdt = chv.Sdt;
            if (cuaHangRepositories.Add(thao)) return "Thành Công";
            else return "Thất Bại";

        }

        public bool CheckMa(string ma)
        {
            var thao = cuaHangRepositories.GetCuaHang().FirstOrDefault(a => a.Ma == ma);
                if(thao!=null) return true;
                else return false;  
        }

        public string Delete(CuaHangView chv)
        {
            if (chv == null) return "Thất Bại";
            CuaHang thao = new CuaHang();
            thao.ID = chv.ID;
            if (cuaHangRepositories.Delete(thao)) return "Thành Công";
            else return "Thất Bại";
        }

        public List<CuaHangView> GetCuaHang()
        {
            List<CuaHangView> listch = new List<CuaHangView>();
            listch = (
                from a in cuaHangRepositories.GetCuaHang()
                select new CuaHangView
                {
                    ID = a.ID,
                    Ma = a.Ma,
                    Ten = a.Ten,
                    DiaChi = a.DiaChi,
                    Sdt = a.Sdt
                }
                ).ToList();
            return listch;
        }

        public string Update(CuaHangView chv)
        {
            if (chv == null) return "Thất Bại";
            CuaHang thao = new CuaHang();
            thao.ID = chv.ID;
            thao.Ten = chv.Ten;
        //    thao.Ma = chv.Ma;
            thao.DiaChi = chv.DiaChi;
            thao.Sdt = chv.Sdt;
            if (cuaHangRepositories.Update(thao)) return "Thành Công";
            else return "Thất Bại";
        }
    }
}
