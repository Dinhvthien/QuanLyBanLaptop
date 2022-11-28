using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ImeiDaBanView
    {
        public Guid ID { get; set; }
        public Guid IDHoaDonChiTiet { get; set; }
        public string SoEmei { get; set; }
        public virtual HoaDonChiTiet HoaDonChiTiet { get; set; }
        public string MaHDCT { get; set; }

    }
}
