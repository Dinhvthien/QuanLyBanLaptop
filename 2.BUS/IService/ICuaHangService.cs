using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
