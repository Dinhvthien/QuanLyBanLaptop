using _1.DAL.IRepositories;
using _1.DAL.Models;

namespace _1.DAL.Repositories
{
    public class ImeiDaBanRepositories : IImeiDaBanRepositories
    {
        BanHangDbContext context = new BanHangDbContext();
        public bool Add(ImeiDaBan imeiDaBan)
        {
            if (imeiDaBan == null) return false;
            context.ImeiDaBans.Add(imeiDaBan);
            context.SaveChanges();
            return true;
        }

        public List<ImeiDaBan> GetImeiDB()
        {
            return context.ImeiDaBans.ToList();
        }
    }
}
