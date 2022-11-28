using _2.BUS.ViewModels;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IService
{
    public interface IImeiDaBanService
    {
        string Add(ImeiDaBanView imdbv);
        List<ImeiDaBanView> GetImeiDaBan();
    }
}
