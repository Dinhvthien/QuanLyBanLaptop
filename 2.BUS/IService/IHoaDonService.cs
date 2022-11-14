using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IHoaDonService
    {
        string Add(HoaDonView hdview);
        string Update(HoaDonView hdview);
        string Delete(HoaDonView hdview);
        bool CheckMa(string ma);
        List<HoaDonView> GetHoaDon();
    }
}
