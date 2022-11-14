using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IGiaTriRepositories
    {
        bool Add(GiaTri gt);
        bool Update(GiaTri gt);
        bool Delete(GiaTri gt);
        List<GiaTri> GetGiaTri();
    }
}
