using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class KhachHangService : IKhachHangService
    {
        IKhachHangRepositories khachHangRepositories = new KhachHangRepositories();
        public string AddKhachHang(KhachHangView khv)
        {
            if (khv == null) return "Thất bại";
            KhachHang thao = new KhachHang();
            thao.ID = khv.ID;
            thao.HoTen = khv.HoTen;
            thao.DiaChi = khv.DiaChi;
            thao.SDT = khv.SDT;
            if (khachHangRepositories.Add(thao)) return "Thành Công";
            else return "Thất bại";
        }

        public bool CheckSDT(string sdt)
        {
            var t = khachHangRepositories.GetKhachHang();
            var thao = t.FirstOrDefault(a => a.SDT == sdt);
            if (thao != null) return true;
            else return false;
        }

        public string DeleteKhachHang(KhachHangView khv)
        {
            if (khv == null) return "Thất bại";
            KhachHang thao = new KhachHang();
            thao.ID = khv.ID;
            if (khachHangRepositories.Delete(thao)) return "Thành Công";
            else return "Thất bại";
        }

        public List<KhachHangView> FindKhachHang(string sdt)
        {
            List<KhachHangView> listkhv = new List<KhachHangView>();
            listkhv = (
                from a in khachHangRepositories.GetKhachHang().Where(a => a.SDT.Contains(sdt))
                select new KhachHangView()
                {
                    ID = a.ID,
                    HoTen = a.HoTen,
                    DiaChi = a.DiaChi,
                    SDT = a.SDT
                }
                ).ToList();
            return listkhv;
        }

        public List<KhachHangView> GetKhachHang()
        {
            List<KhachHangView> listkhv = new List<KhachHangView>();
            listkhv = (
                from a in khachHangRepositories.GetKhachHang()
                select new KhachHangView()
                {
                    ID = a.ID,
                    HoTen = a.HoTen,
                    DiaChi = a.DiaChi,
                    SDT = a.SDT
                }
                ).ToList();
            return listkhv;
        }

        public string UpdateKhachHang(KhachHangView khv)
        {
            if (khv == null) return "Thất bại";
            KhachHang thao = new KhachHang();
            thao.ID = khv.ID;
            thao.HoTen = khv.HoTen;
            thao.DiaChi = khv.DiaChi;
            if (khachHangRepositories.Update(thao)) return "Thành Công";
            else return "Thất bại";
        }
    }
}
