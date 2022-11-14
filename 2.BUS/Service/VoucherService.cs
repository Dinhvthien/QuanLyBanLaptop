using _1.DAL.IRepositories;
using _1.DAL.Models;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class VoucherService : IVoucherService
    {
        IVoucherRepositories voucherRepositories = new VoucherRepositories();
        public string Add(VoucherView vv)
        {
            if (vv == null) return "Thất bại";
            Voucher t = new Voucher();
            t.ID = vv.ID;
            t.Ma = vv.Ma;
            t.Ten = vv.Ten;
            t.StartDay = vv.StartDay;
            t.EndDay = vv.EndDay;
            t.GiaTri = vv.GiaTri;
            t.SoLuong = vv.SoLuong;
            if (voucherRepositories.Add(t)) return "Thành công";
            else return "Thất bại";
        }

        public bool CheckMa(string ma)
        {
            var listvc = voucherRepositories.GetVoucher();
            var t = listvc.FirstOrDefault(a => a.Ma == ma);
            if (t != null) return true;
            else return false;
        }

        public string Delete(VoucherView vv)
        {
            if (vv == null) return "Thất bại";
            Voucher t = new Voucher();
            t.ID = vv.ID;
            if (voucherRepositories.Delete(t)) return "Thành công";
            else return "Thất bại";
        }

        public List<VoucherView> GetVoucher()
        {
            List<VoucherView> listvo = new List<VoucherView>();
            listvo = (
                 from a in voucherRepositories.GetVoucher()
                 select new VoucherView
                 {
                     ID = a.ID,
                     Ma = a.Ma,
                     Ten = a.Ten,
                     StartDay = a.StartDay,
                     EndDay = a.EndDay,
                     GiaTri = a.GiaTri,
                     SoLuong = a.SoLuong
                 }
                ).ToList();
            return listvo;
        }

        public string Update(VoucherView vv)
        {
            if (vv == null) return "Thất bại";
            Voucher t = new Voucher();
            t.ID = vv.ID;

            t.Ten = vv.Ten;
            t.StartDay = vv.StartDay;
            t.EndDay = vv.EndDay;
            t.GiaTri = vv.GiaTri;
            t.SoLuong = vv.SoLuong;
            if (voucherRepositories.Update(t)) return "Thành công";
            else return "Thất bại";
        }
    }
}
