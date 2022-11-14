using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class GiaTri
    {

        public Guid ID { get; set; }
        public Guid IDThuocTinh { get; set; }
        public string ThongSo { get; set; }
        public string Ma { get; set; }
        public virtual ThuocTinh ThuocTinh { get; set; }
    }
}
