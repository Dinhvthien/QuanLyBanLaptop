using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IHoaDonChiTietService
    {
        string Add(HoaDonChiTietView hdctview);
        string Update(HoaDonChiTietView hdctview);
        string Delete(HoaDonChiTietView hdctview);
        //bool CheckMa(string ma);
        List<HoaDonChiTietView> GetHoaDonChiTiet();
    }
}
