using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IChucVuService
    {
        string Add(ChucVuView cvv);
        string Update(ChucVuView cvv);
        string Delete(ChucVuView cvv);
        bool CheckMa(string ma);
        List<ChucVuView> GetChucVu();
    }
}
