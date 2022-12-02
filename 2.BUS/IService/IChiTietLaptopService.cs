using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IChiTietLaptopService
    {
        string Add(ChiTietLaptopView ctltview);
        string Update(ChiTietLaptopView ctltview);
        string Delete(ChiTietLaptopView ctltview);
        bool CheckMa(string ma);
        List<ChiTietLaptopView> GetChiTietLaptop();
        List<ChiTietLaptopView> GetChiTietLaptopNoJoin();
        string UpdateSoLuong(ChiTietLaptopView ctltview);
    }
}
