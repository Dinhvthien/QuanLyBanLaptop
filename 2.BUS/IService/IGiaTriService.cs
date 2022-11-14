using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
