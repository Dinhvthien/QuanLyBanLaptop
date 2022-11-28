using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ImeiView
    {
        public Guid ID { get; set; }
        public Guid IDChiTietLaptop { get; set; }
        public string SoEmei { get; set; }
        public virtual ChiTietLaptop ChiTietLaptop { get; set; }
        public string MaCTLT { get; set; }
    }
}
