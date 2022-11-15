using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IGiaTriService
    {
        string AddGt(GiaTriView gtv);
        string UpDateGt(GiaTriView gtv);
        string DeleteGt(GiaTriView gtv);
        List<GiaTriView> GetGiaTri();
        bool CheckMaGt(string ma);
    }
}
