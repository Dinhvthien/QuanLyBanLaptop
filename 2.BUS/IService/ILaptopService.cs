using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface ILaptopService
    {
        string AddLaptop(LaptopView ltv);
        string UpdateLaptop(LaptopView ltv);
        string DeleteLaptop(LaptopView ltv);
        List<LaptopView> GetLaptop();
        bool CheckMa(string ma);
    }
}
