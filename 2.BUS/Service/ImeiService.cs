using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class ImeiService : IImeiService
    {
        IImeiRepositories imeiRepositories = new ImeiRepositories();
        IChiTietLaptopRepositories chiTietLaptopRepositories = new ChiTietLaptopRepositories();
        public string Add(ImeiView imv)
        {
            if (imv == null) return "Thất Bại";
            Imei i = new Imei();
            i.ID = imv.ID;
            i.SoEmei = imv.SoEmei;
            i.IDChiTietLaptop = imv.IDChiTietLaptop;
            if (imeiRepositories.Add(i)) return "Thành Công";
            else return "Thất Bại";
        }

        public List<ImeiView> GetImei()
        {
            List<ImeiView> listimv = new List<ImeiView>();
            listimv = (from a in imeiRepositories.GetImei()
                   //    join b in chiTietLaptopRepositories.GetChiTietLaptop() on a.IDChiTietLaptop equals b.ID
                       select new ImeiView()
                       {
                           ID = a.ID,
                           SoEmei = a.SoEmei,
                           //MaCTLT = b.Ma
                       }
                ).ToList();
            return listimv; 
        }
    }
}
