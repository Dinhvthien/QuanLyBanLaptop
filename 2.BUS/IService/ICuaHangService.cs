using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface ICuaHangService
    {
        string Add(CuaHangView chv);
        string Update(CuaHangView chv);
        string Delete(CuaHangView chv);
        List<CuaHangView> GetCuaHang();
        bool CheckMa(string ma);
    }
}
