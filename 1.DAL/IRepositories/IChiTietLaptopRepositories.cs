using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChiTietLaptopRepositories
    {
        bool Add(ChiTietLaptop ctlt);
        bool Update(ChiTietLaptop ctlt);
        bool Delete(ChiTietLaptop ctlt);
        List<ChiTietLaptop> GetChiTietLaptop();
    }
}
