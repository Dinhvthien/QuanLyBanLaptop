using _1.DAL.Models;

namespace _2.BUS.ViewModels
{
    public class GiaTriView
    {
        public Guid ID { get; set; }
        public Guid IDThuocTinh { get; set; }
        public string ThongSo { get; set; }
        public string Ma { get; set; }
        public virtual ThuocTinh ThuocTinh { get; set; }
        public string MaThuocTinh { get; set; }
    }
}
