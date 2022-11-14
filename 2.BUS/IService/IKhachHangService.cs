using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IKhachHangService
    {
        string AddKhachHang(KhachHangView khv);
        string UpdateKhachHang(KhachHangView khv);
        string DeleteKhachHang(KhachHangView khv);
        List<KhachHangView> GetAllKhachHang();
        bool CheckMa(string ma);
    }
}
