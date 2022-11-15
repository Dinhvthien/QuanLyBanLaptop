using _1.DAL.Models;

namespace _1.DAL.IRepositories
{
    public interface INhanVienRepositories
    {
        bool Add(NhanVien nv);
        bool Update(NhanVien nv);
        bool Delete(NhanVien nv);
        List<NhanVien> GetNhanVien();
    }
}
