using _1.DAL.IRepositories;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class ImeiRepositories : IImeiRepositories
    {
        BanHangDbContext context = new BanHangDbContext();
        public bool Add(Imei imei)
        {
            if (imei == null) return false;
            context.Imeis.Add(imei);
            context.SaveChanges();
            return true;
        }

        public List<Imei> GetImei()
        {
            return context.Imeis.ToList();
        }
    }
}
