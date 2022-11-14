using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class HoaDonService : IHoaDonService
    {
        IHoaDonRepositories hoaDonRepositories = new HoaDonRepositories();
        INhanVienRepositories nhanVienRepositories = new NhanVienRepositories();
        IKhachHangRepositories khachHangRepositories = new KhachHangRepositories();
        IVoucherRepositories voucherRepositories = new VoucherRepositories();
        public string Add(HoaDonView hdview)
        {
            if (hdview == null) return "Thất bại";
            HoaDon t = new HoaDon();
            t.ID = hdview.ID;
            t.Ma = hdview.Ma;
            t.NgayTao = hdview.NgayTao;
            t.TenNguoiNhan = hdview.TenNguoiNhan;
            t.TinhTrang = hdview.TinhTrang;
            t.IdNhanVien = hdview.IdNhanVien;
            t.IdKhachHang = hdview.IdKhachHang;
            t.IdVoucher = hdview.IdVoucher;
            t.SdtNguoiNhan = hdview.SdtNguoiNhan;
            if (hoaDonRepositories.Add(t)) return "Thành công";
            else return "Thất bại";
        }

        public bool CheckMa(string ma)
        {
            var listh = hoaDonRepositories.GetHoaDon();
            var t = listh.FirstOrDefault(a => a.Ma == ma);
            if (t != null) return true;
            else return false;
        }

        public string Delete(HoaDonView hdview)
        {
            if (hdview == null) return "Thất bại";
            HoaDon t = new HoaDon();
            t.ID = hdview.ID;
            if (hoaDonRepositories.Delete(t)) return "Thành công";
            else return "Thất bại";
        }

        public List<HoaDonView> GetHoaDon()
        {
            List<HoaDonView> listhoadon = new List<HoaDonView>();
            listhoadon = (
                from a in hoaDonRepositories.GetHoaDon()
                join b in nhanVienRepositories.GetNhanVien() on a.IdNhanVien equals b.ID
                join c in khachHangRepositories.GetKhachHang() on a.IdKhachHang equals c.ID
                join d in voucherRepositories.GetVoucher() on a.IdVoucher equals d.ID
                select new HoaDonView
                {
                    ID = a.ID,
                    Ma = a.Ma,
                    NgayTao = a.NgayTao,
                    TenNguoiNhan = a.TenNguoiNhan,
                    TinhTrang = a.TinhTrang,
                    SdtNguoiNhan = a.SdtNguoiNhan,
                    IdNhanVien = a.IdNhanVien,
                    IdKhachHang = a.IdKhachHang,
                    IdVoucher = a.IdVoucher,
                    MaNhanVien = b.Ma,
                    MaKhachHang = c.Ma,
                    MaVoucher = d.Ma
                }
                ).ToList();
            return listhoadon;
        }

        public string Update(HoaDonView hdview)
        {
            if (hdview == null) return "Thất bại";
            HoaDon t = new HoaDon();
            t.ID = hdview.ID;
            t.NgayTao = hdview.NgayTao;
            t.TenNguoiNhan = hdview.TenNguoiNhan;
            t.TinhTrang = hdview.TinhTrang;
            t.SdtNguoiNhan = hdview.SdtNguoiNhan;
            if (hoaDonRepositories.Update(t)) return "Thành công";
            else return "Thất bại";
        }
    }
}
