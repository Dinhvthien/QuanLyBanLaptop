using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ThuocTinhRepositories : IThuocTinhRepositories
    {
        BanHangDbContext context = new BanHangDbContext();
        public bool Add(ThuocTinh tt)
        {
           if(tt ==null) return false;
           context.ThuocTinhs.Add(tt);
            context.SaveChanges();
            return true;
        }

        public bool Delete(ThuocTinh tt)
        {
            if (tt == null) return false;
            var t = context.ThuocTinhs.Find(tt.ID);
            context.Remove(t);
            context.SaveChanges();
            return true;
        }

        public List<ThuocTinh> GetThuocTinh()
        {
            return context.ThuocTinhs.ToList();
        }

        public bool Update(ThuocTinh tt)
        {
            if (tt == null) return false;
            var t = context.ThuocTinhs.Find(tt.ID);
            t.Ten=tt.Ten;
            context.Update(t);
            context.SaveChanges();
            return true;
        }
    }
}
