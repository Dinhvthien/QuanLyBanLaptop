using _1.DAL.Models;

namespace _2.BUS.ViewModels
{
    public class ThuocTinhView
    {
        public Guid ID { get; set; }
        public Guid IDLaptop { get; set; }
        public string Ten { get; set; }
        public string Ma { get; set; }
        public virtual Laptop Laptop { get; set; }
        public string MaLaptop { get; set; }
    }
}
