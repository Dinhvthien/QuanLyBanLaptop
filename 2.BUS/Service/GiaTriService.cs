using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class GiaTriService : IGiaTriService
    {
        IGiaTriRepositories giaTriRepositories = new GiaTriRepositories();
        IThuocTinhRepositories thuocTinhRepositories = new ThuocTinhRepositories();
        public string AddGt(GiaTriView gtv)
        {
            if (gtv == null) return "Thất bại";
            GiaTri x = new GiaTri();
            x.ID = gtv.ID;
            x.IDThuocTinh = gtv.IDThuocTinh;
            x.Ma = gtv.Ma;
            x.ThongSo = gtv.ThongSo;
            if (giaTriRepositories.Add(x)) return "Thành Công";
            else return "Thất bại";
        }

        public bool CheckMaGt(string ma)
        {
            var listgt = giaTriRepositories.GetGiaTri();
            var t = listgt.FirstOrDefault(a => a.Ma == ma);
            if (t != null) return true;
            else return false;
        }

        public string DeleteGt(GiaTriView gtv)
        {
            if (gtv == null) return "Thất bại";
            GiaTri x = new GiaTri();
            x.ID = gtv.ID;
            if (giaTriRepositories.Delete(x)) return "Thành Công";
            else return "Thất bại";
        }

        public List<GiaTriView> GetGiaTri()
        {
            List<GiaTriView> listgtv = new List<GiaTriView>();
            listgtv = (
                from a in giaTriRepositories.GetGiaTri()
                join b in thuocTinhRepositories.GetThuocTinh() on a.IDThuocTinh equals b.ID
                select new GiaTriView
                {
                    ID = a.ID,
                    IDThuocTinh = a.IDThuocTinh,
                    ThongSo = a.ThongSo,
                    Ma = a.Ma,
                    MaThuocTinh = b.Ma
                }
                ).ToList();
            return listgtv;
        }

        public string UpDateGt(GiaTriView gtv)
        {
            if (gtv == null) return "Thất bại";
            GiaTri x = new GiaTri();
            x.ID = gtv.ID;
            x.ThongSo = gtv.ThongSo;
            if (giaTriRepositories.Update(x)) return "Thành Công";
            else return "Thất bại";
        }
    }
}
