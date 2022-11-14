using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class NsxService : INsxService
    {
        INsxRepositories nsxRepositories = new NsxRepositories();
        public string Add(NsxView nsxv)
        {
            if (nsxv == null) return "Thất bại";
            Nsx dell = new Nsx();
            dell.ID = nsxv.ID;
            dell.Ma = nsxv.Ma;
            dell.Ten = nsxv.Ten;
            if (nsxRepositories.Add(dell)) return "Thành công";
            else return "Thất bại";
        }

        public bool CheckMa(string ma)
        {
            var listn = nsxRepositories.GetNsx();
            var t = listn.FirstOrDefault(a => a.Ma == ma);
            if (t != null) return true;
            else return false;
        }

        public string Delete(NsxView nsxv)
        {
            if (nsxv == null) return "Thất bại";
            Nsx dell = new Nsx();
            dell.ID = nsxv.ID;

            if (nsxRepositories.Delete(dell)) return "Thành công";
            else return "Thất bại";
        }

        public List<NsxView> GetNsx()
        {
            List<NsxView> listnsx = new List<NsxView>();
            listnsx = (
                from a in nsxRepositories.GetNsx()
                select new NsxView
                {
                    ID = a.ID,
                    Ma = a.Ma,
                    Ten = a.Ten
                }
                ).ToList();
            return listnsx;
        }

        public string Update(NsxView nsxv)
        {
            if (nsxv == null) return "Thất bại";
            Nsx dell = new Nsx();
            dell.ID = nsxv.ID;
            dell.Ten = nsxv.Ten;
            if (nsxRepositories.Update(dell)) return "Thành công";
            else return "Thất bại";
        }
    }
}
