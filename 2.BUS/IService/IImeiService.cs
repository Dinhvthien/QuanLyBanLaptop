using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IImeiService
    {
        string Add(ImeiView imv);
        List<ImeiView> GetImei();
    }
}
