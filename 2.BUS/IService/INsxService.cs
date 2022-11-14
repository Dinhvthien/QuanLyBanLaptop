using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface INsxService
    {
        string Add(NsxView nsxv);
        string Update(NsxView nsxv);
        string Delete(NsxView nsxv);
        bool CheckMa(string ma);
        List<NsxView> GetNsx();

    }
}
