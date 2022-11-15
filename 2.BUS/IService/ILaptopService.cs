using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface ILaptopService
    {
        string AddLaptop(LaptopView ltv);
        string UpdateLaptop(LaptopView ltv);
        string DeleteLaptop(LaptopView ltv);
        List<LaptopView> GetLaptop();
        bool CheckMa(string ma);
    }
}
