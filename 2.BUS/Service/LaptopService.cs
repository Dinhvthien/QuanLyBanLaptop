using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class LaptopService : ILaptopService
    {
        ILaptopRepositories laptopRepositories = new LaptopRepositories();
        IThuocTinhRepositories thuocTinhRepositories = new ThuocTinhRepositories();
        IGiaTriRepositories giaTriRepositories = new GiaTriRepositories();
        public string AddLaptop(LaptopView ltv)
        {
            if (ltv == null) return "Thất bại";
            Laptop x = new Laptop();
            x.ID = ltv.ID;
            x.Ma = ltv.Ma;
            x.Ten = ltv.Ten;
            if (laptopRepositories.Add(x)) return "Thành công";
            else return "Thất bại";
        }

        public bool CheckMa(string ma)
        {
            var listlap = laptopRepositories.GetLaptop();
            var x = listlap.FirstOrDefault(a => a.Ma == ma);
            if (x != null) return true;
            else return false;
        }

        public string DeleteLaptop(LaptopView ltv)
        {
            if (ltv == null) return "Thất bại";
            Laptop x = new Laptop();
            x.ID = ltv.ID;
            if (laptopRepositories.Delete(x)) return "Thành công";
            else return "Thất bại";
        }

        public List<LaptopView> GetLaptop()
        {
            List<LaptopView> listlt = new List<LaptopView>();
            listlt = (
                from a in laptopRepositories.GetLaptop()
                join e in thuocTinhRepositories.GetThuocTinh() on a.ID equals e.IDLaptop
                join f in giaTriRepositories.GetGiaTri() on e.ID equals f.IDThuocTinh
                select new LaptopView
                {
                    ID = a.ID,
                    Ma = a.Ma,
                    Ten = a.Ten,
                    TenThuocTinh = e.Ten,
                    ThongSoGiaTri = f.ThongSo
                }
                ).ToList();
            return listlt;

        }

        public string UpdateLaptop(LaptopView ltv)
        {
            if (ltv == null) return "Thất bại";
            Laptop x = new Laptop();
            x.ID = ltv.ID;
            x.Ten = ltv.Ten;
            if (laptopRepositories.Update(x)) return "Thành công";
            else return "Thất bại";
        }
    }
}
