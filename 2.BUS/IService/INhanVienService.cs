using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface INhanVienService
    {
        string AddNhanVien(NhanVienView nvv);
        string UpdateNhanVien(NhanVienView nvv);
        string DeleteNhanVien(NhanVienView nvv);
        bool CheckMa(string ma);
        List<NhanVienView> GetAllNhanVien();
        bool CheckSdtMkNhanVien(string taikhoan, string matkhau);


    }
}
