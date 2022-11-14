using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class VoucherRepositories : IVoucherRepositories
    {
        BanHangDbContext context = new BanHangDbContext();
        public bool Add(Voucher vc)
        {
            if (vc == null) return false;
            context.Vouchers.Add(vc);
            context.SaveChanges();
            return true;
        }

        public bool Delete(Voucher vc)
        {
            if (vc == null) return false;
            var t = context.Vouchers.FirstOrDefault(a => a.ID == vc.ID);
            context.Remove(t);
            context.SaveChanges();
            return true;
        }

        public List<Voucher> GetVoucher()
        {
            return context.Vouchers.ToList();
        }

        public bool Update(Voucher vc)
        {
            if (vc == null) return false;
            var t = context.Vouchers.FirstOrDefault(a => a.ID == vc.ID);
            t.Ten = vc.Ten;
            t.StartDay = vc.StartDay;
            t.EndDay = vc.EndDay;
            t.GiaTri = vc.GiaTri;
            t.SoLuong = vc.SoLuong;
            context.Update(t);
            context.SaveChanges();
            return true;
        }
    }
}
