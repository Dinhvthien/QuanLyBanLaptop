using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class ChucVuService : IChucVuService
    {
        IChucVuRepositories chucVuRepositories = new ChucVuRepositories();
        public string Add(ChucVuView cvv)
        {
            if (cvv == null) return "Thất Bại";
            var thao = new ChucVu();
            thao.ID = cvv.ID;
            thao.Ma = cvv.Ma;
            thao.Ten = cvv.Ten;
            if (chucVuRepositories.Add(thao)) return "Thành Công";
            else return "Thất Bại";
        }

        public bool CheckMa(string ma)
        {
            var thao = chucVuRepositories.GetChucVu().FirstOrDefault(a => a.Ma == ma);
            if (thao != null) return true;
            else return false;
        }

        public List<ChucVuView> GetChucVu()
        {
            List<ChucVuView> list = new List<ChucVuView>();
            list = (
                from a in chucVuRepositories.GetChucVu()
                select new ChucVuView
                {
                    ID = a.ID,
                    Ma = a.Ma,
                    Ten = a.Ten
                }
              ).ToList();
            return list;
        }

        public string Delete(ChucVuView cvv)
        {
            if (cvv == null) return "Thất Bại";
            var thao = new ChucVu();
            thao.ID = cvv.ID;
            if (chucVuRepositories.Delete(thao)) return "Thành Công";
            else return "Thất Bại";
        }

        public string Update(ChucVuView cvv)
        {
            if (cvv == null) return "Thất Bại";
            var thao = new ChucVu();
            thao.ID = cvv.ID;
            thao.Ten = cvv.Ten;
            if (chucVuRepositories.Update(thao)) return "Thành Công";
            else return "Thất Bại";
        }
    }
}
