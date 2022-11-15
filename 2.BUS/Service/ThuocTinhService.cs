using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class ThuocTinhService : IThuocTinhService
    {
        IThuocTinhRepositories thuocTinhRepositories = new ThuocTinhRepositories();
        ILaptopRepositories laptopRepositories = new LaptopRepositories();
        public string AddTt(ThuocTinhView ttv)
        {
            if (ttv == null) return "Thất bại";
            ThuocTinh t = new ThuocTinh();
            t.ID = ttv.ID;
            t.Ma = ttv.Ma;
            t.Ten = ttv.Ten;
            t.IDLaptop = ttv.IDLaptop;
            if (thuocTinhRepositories.Add(t)) return "Thành công";
            else return "Thất bại";
        }

        public bool CheckMaTt(string ma)
        {
            var listtt = thuocTinhRepositories.GetThuocTinh();
            var t = listtt.FirstOrDefault(a => a.Ma == ma);
            if (t != null) return true;
            else return false;
        }

        public string DeleteTt(ThuocTinhView ttv)
        {
            if (ttv == null) return "Thất bại";
            ThuocTinh t = new ThuocTinh();
            t.ID = ttv.ID;
            if (thuocTinhRepositories.Delete(t)) return "Thành công";
            else return "Thất bại";
        }

        public List<ThuocTinhView> GetThuocTinh()
        {
            List<ThuocTinhView> listthuoctinh = new List<ThuocTinhView>();
            listthuoctinh = (
                    from a in thuocTinhRepositories.GetThuocTinh()
                    join b in laptopRepositories.GetLaptop() on a.IDLaptop equals b.ID
                    select new ThuocTinhView
                    {
                        ID = a.ID,
                        Ten = a.Ten,
                        Ma = a.Ma,
                        MaLaptop = b.Ma
                    }
                       ).ToList();
            return listthuoctinh;
        }

        public string UpdateTt(ThuocTinhView ttv)
        {
            if (ttv == null) return "Thất bại";
            ThuocTinh t = new ThuocTinh();
            t.ID = ttv.ID;
            t.Ten = ttv.Ten;
            if (thuocTinhRepositories.Update(t)) return "Thành công";
            else return "Thất bại";
        }
    }
}
