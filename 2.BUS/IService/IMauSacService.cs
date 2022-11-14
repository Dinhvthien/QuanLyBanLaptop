using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IMauSacService
    {
        string Add(MauSacView msv);
        string Update(MauSacView msv);
        string Delete(MauSacView msv);
        bool CheckMa(string ma);
        List<MauSacView> GetMauSac();

    }
}
