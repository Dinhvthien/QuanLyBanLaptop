using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class Voucher
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public decimal GiaTri { get; set; }
        public int SoLuong { get; set; }
    }
}
