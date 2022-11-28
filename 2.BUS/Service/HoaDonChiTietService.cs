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
        IChiTietLaptopRepositories chiTietLaptopRepositories = new ChiTietLaptopRepositories();
        IHoaDonRepositories hoaDonRepositories = new HoaDonRepositories();
        IImeiDaBanRepositories imeiDaBanRepositories = new ImeiDaBanRepositories();
        public string Add(HoaDonChiTietView hdctview)
        {
            if (hdctview == null) return "Thất bại";
            HoaDonChiTiet hct = new HoaDonChiTiet();
            hct.ID = hdctview.ID;
            hct.Ma = hdctview.Ma;
            hct.IDChiTietLapTop = hdctview.IDChiTietLapTop;
            hct.IDHoaDon = hdctview.IDHoaDon;
            hct.NgayTao = hdctview.NgayTao;
            hct.SoLuong = hdctview.SoLuong;
            hct.GiaTruoc = hdctview.GiaTruoc;
            hct.GiaSauKhiGiam = hdctview.GiaSauKhiGiam;
            hct.TinhTrang = hdctview.TinhTrang;
            if (hoaDonChiTietRepositories.Add(hct)) return "Thành công";
            else return "Thất bại";
        }

        public string Delete(HoaDonChiTietView hdctview)
        {
            if (hdctview == null) return "Thất bại";
            HoaDonChiTiet hct = new HoaDonChiTiet();
            hct.ID = hdctview.ID;
            if (hoaDonChiTietRepositories.Delete(hct)) return "Thành công";
            else return "Thất bại";
        }

        public List<HoaDonChiTietView> GetHoaDonChiTiet()
        {
            List<HoaDonChiTietView> listssd = new List<HoaDonChiTietView>();
            listssd = (
                          from a in hoaDonChiTietRepositories.GetHoaDonChiTiet()
                          join b in chiTietLaptopRepositories.GetChiTietLaptop() on a.IDChiTietLapTop equals b.ID
                          join c in hoaDonRepositories.GetHoaDon() on a.IDHoaDon equals c.ID
                          join d in imeiDaBanRepositories.GetImeiDB() on a.ID equals d.IDHoaDonChiTiet
                          select new HoaDonChiTietView
                          {
                              ID = a.ID,
                              Ma = a.Ma,
                              MaChiTietLaptop = b.Ma,
                              MaHoaDon = c.Ma,
                              SoLuong = a.SoLuong,
                              GiaTruoc = a.GiaTruoc,
                              NgayTao = a.NgayTao,
                              GiaSauKhiGiam = a.GiaSauKhiGiam,
                              TinhTrang = a.TinhTrang,
                            //  GiamGia = a.GiaTruoc - a.GiaSauKhiGiam,
                              SoImei = d.SoEmei,
                              GiaNhap = b.GiaNhap

                          }
                ).ToList();
            return listssd;
        }

        public List<HoaDonChiTietView> GetHoaDonChiTietNoJoin()
        {
            List<HoaDonChiTietView> listssd = new List<HoaDonChiTietView>();
            listssd = (
                          from a in hoaDonChiTietRepositories.GetHoaDonChiTiet()
                          join b in chiTietLaptopRepositories.GetChiTietLaptop() on a.IDChiTietLapTop equals b.ID
                          join c in hoaDonRepositories.GetHoaDon() on a.IDHoaDon equals c.ID
           
                          select new HoaDonChiTietView
                          {
                              ID = a.ID,
                              Ma = a.Ma,
                              MaChiTietLaptop = b.Ma,
                              MaHoaDon = c.Ma,
                              SoLuong = a.SoLuong,
                              GiaTruoc = a.GiaTruoc,
                              NgayTao = a.NgayTao,
                              GiaSauKhiGiam = a.GiaSauKhiGiam,
                              TinhTrang = a.TinhTrang,
                              GiamGia = a.GiaTruoc - a.GiaSauKhiGiam
                              
                          }
                ).ToList();
            return listssd;
        }

        public string Update(HoaDonChiTietView hdctview)
        {
            if (hdctview == null) return "Thất bại";
            HoaDonChiTiet hct = new HoaDonChiTiet();
            hct.ID = hdctview.ID;
            hct.SoLuong = hdctview.SoLuong;
            hct.GiaTruoc = hdctview.GiaTruoc;
            hct.GiaSauKhiGiam = hdctview.GiaSauKhiGiam;
            hct.TinhTrang = hdctview.TinhTrang;
            if (hoaDonChiTietRepositories.Update(hct)) return "Thành công";
            else return "Thất bại";
        }
        public string UpdateTrangThai(HoaDonChiTietView hdctview)
        {
            if (hdctview == null) return "Thất bại";
            HoaDonChiTiet hct = new HoaDonChiTiet();
            hct.ID = hdctview.ID;
            hct.TinhTrang = hdctview.TinhTrang;
            if (hoaDonChiTietRepositories.UpdateTrangThai(hct)) return "Thành công";
            else return "Thất bại";
        }
    }
}
