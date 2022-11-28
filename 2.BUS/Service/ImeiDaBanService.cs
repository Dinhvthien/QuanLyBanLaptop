using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class ImeiDaBanService : IImeiDaBanService
    {
        IImeiDaBanRepositories imeiDaBanRepositories = new ImeiDaBanRepositories();
        IHoaDonChiTietRepositories hoaDonChiTietRepositories = new HoaDonChiTietRepositories();
        public string Add(ImeiDaBanView imdbv)
        {
            if (imdbv == null) { return "Thất Bại"; }
            ImeiDaBan s = new ImeiDaBan();
            s.ID = imdbv.ID;
            s.SoEmei = imdbv.SoEmei;
            s.IDHoaDonChiTiet = imdbv.IDHoaDonChiTiet;
            if (imeiDaBanRepositories.Add(s)) return "Thành Công";
            else return "Thất Bại";

        }

        public List<ImeiDaBanView> GetImeiDaBan()
        {
            List<ImeiDaBanView> listimeidb = new List<ImeiDaBanView>();
            listimeidb = (
                            from a in imeiDaBanRepositories.GetImeiDB()
                            join b in hoaDonChiTietRepositories.GetHoaDonChiTiet() on a.IDHoaDonChiTiet equals b.ID
                            select new ImeiDaBanView()
                            {
                                ID = a.ID,
                                SoEmei = a.SoEmei,
                                MaHDCT = b.Ma
                            }
                ).ToList();
            return listimeidb;
        }
    }
}
