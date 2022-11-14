using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IThuocTinhService
    {
        string AddTt(ThuocTinhView ttv);
        string UpdateTt(ThuocTinhView ttv);
        string DeleteTt(ThuocTinhView ttv);
        bool CheckMaTt(string ma);
        List<ThuocTinhView> GetThuocTinh();
    }
}
