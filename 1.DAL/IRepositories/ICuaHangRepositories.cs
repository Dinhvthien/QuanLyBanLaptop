using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface ICuaHangRepositories
    {
        bool Add(CuaHang ch);
        bool Update(CuaHang ch);
        bool Delete(CuaHang ch);
        List<CuaHang> GetCuaHang();
    }
}
