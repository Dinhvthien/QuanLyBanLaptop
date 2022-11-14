using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface IVoucherRepositories
    {
        bool Add(Voucher vc);
        bool Update(Voucher vc);
        bool Delete(Voucher vc);
        List<Voucher> GetVoucher();
    }
}
