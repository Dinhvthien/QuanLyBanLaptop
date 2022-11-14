using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class HoaDonChiTietService : IHoaDonChiTietService
    {
        IHoaDonChiTietRepositories hoaDonChiTietRepositories = new HoaDonChiTietRepositories();
        public string Add(HoaDonChiTietView hdctview)
        {
            if (hdctview == null) return "Thất bại";
            HoaDonChiTiet hct = new HoaDonChiTiet();
            hct.IDChiTietLapTop = hdctview.IDChiTietLapTop;
            hct.IDHoaDon = hdctview.IDHoaDon;
            hct.NgayTao = hdctview.NgayTao;
            hct.SoLuong = hdctview.SoLuong;
            hct.GiaTruoc = hdctview.GiaTruoc;
            hct.GiaSauKhiGiam = hdctview.GiaSauKhiGiam;
            if (hoaDonChiTietRepositories.Add(hct)) return "Thành công";
            else return "Thất bại";
        }

        public string Delete(HoaDonChiTietView hdctview)
        {
            if (hdctview == null) return "Thất bại";
            HoaDonChiTiet hct = new HoaDonChiTiet();
            hct.IDChiTietLapTop = hdctview.IDChiTietLapTop;
            hct.IDHoaDon = hdctview.IDHoaDon;
            if (hoaDonChiTietRepositories.Delete(hct)) return "Thành công";
            else return "Thất bại";
        }

        public List<HoaDonChiTietView> GetHoaDonChiTiet()
        {
            List<HoaDonChiTietView> listssd = new List<HoaDonChiTietView>();
            listssd = (
                          from a in hoaDonChiTietRepositories.GetHoaDonChiTiet()
                          select new HoaDonChiTietView
                          {
                              IDChiTietLapTop = a.IDChiTietLapTop,
                              IDHoaDon = a.IDHoaDon,
                              SoLuong = a.SoLuong,
                              GiaTruoc = a.GiaTruoc,
                              NgayTao = a.NgayTao,
                              GiaSauKhiGiam = a.GiaSauKhiGiam
                          }
                ).ToList();
            return listssd;
        }

        public string Update(HoaDonChiTietView hdctview)
        {
            if (hdctview == null) return "Thất bại";
            HoaDonChiTiet hct = new HoaDonChiTiet();
            hct.IDChiTietLapTop = hdctview.IDChiTietLapTop;
            hct.IDHoaDon = hdctview.IDHoaDon;
            hct.NgayTao = hdctview.NgayTao;
            hct.SoLuong = hdctview.SoLuong;
            hct.GiaTruoc = hdctview.GiaTruoc;
            hct.GiaSauKhiGiam = hdctview.GiaSauKhiGiam;
            if (hoaDonChiTietRepositories.Update(hct)) return "Thành công";
            else return "Thất bại";
        }
    }
}
