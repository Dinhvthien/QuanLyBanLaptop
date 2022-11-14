using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IChucVuService
    {
        string Add(ChucVuView cvv);
        string Update(ChucVuView cvv);
        string Delete(ChucVuView cvv);
        bool CheckMa(string ma);
        List<ChucVuView> GetChucVu();
    }
}
