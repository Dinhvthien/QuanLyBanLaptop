using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface IKhachHangRepositories
    {
        bool Add(KhachHang kh);
        bool Update(KhachHang kh);
        bool Delete(KhachHang kh);
        List<KhachHang> GetKhachHang();
    }
}
