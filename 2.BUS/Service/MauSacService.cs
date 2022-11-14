using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class MauSacService : IMauSacService
    {
        IMauSacRepositories mauSacRepositories = new MauSacRepositories();
        public string Add(MauSacView msv)
        {
            if (msv == null) return "Thất bại";
            MauSac red = new MauSac();
            red.ID = msv.ID;
            red.Ma = msv.Ma;
            red.Ten = msv.Ten;
            if (mauSacRepositories.Add(red)) return "Thành công";
            else return "Thất bại";
        }

        public bool CheckMa(string ma)
        {
            var listms = mauSacRepositories.GetMauSac();
            var blu = listms.FirstOrDefault(a => a.Ma == ma);
            if (blu != null) return true;
            else return false;

        }

        public string Delete(MauSacView msv)
        {
            if (msv == null) return "Thất bại";
            MauSac red = new MauSac();
            red.ID = msv.ID;
            if (mauSacRepositories.Delete(red)) return "Thành công";
            else return "Thất bại";
        }

        public List<MauSacView> GetMauSac()
        {
            List<MauSacView> listms = new List<MauSacView>();
            listms = (
                   from a in mauSacRepositories.GetMauSac()
                   select new MauSacView
                   {
                       ID = a.ID,
                       Ma = a.Ma,
                       Ten = a.Ten
                   }
                  ).ToList();
            return listms;
        }

        public string Update(MauSacView msv)
        {
            if (msv == null) return "Thất bại";
            MauSac red = new MauSac();
            red.ID = msv.ID;

            red.Ten = msv.Ten;
            if (mauSacRepositories.Update(red)) return "Thành công";
            else return "Thất bại";
        }
    }
}
