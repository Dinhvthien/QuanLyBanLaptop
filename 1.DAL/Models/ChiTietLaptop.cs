namespace _1.DAL.Models
{
    public class ChiTietLaptop
    {
        public Guid ID { get; set; }
        public string Ma { get; set; }
        public Guid IDMauSac { get; set; }
        public Guid IDLaptop { get; set; }
        public Guid IDNsx { get; set; }
        public string MoTa { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal Giaban { get; set; }
        public virtual MauSac MauSac { get; set; }
        public virtual Laptop Laptop { get; set; }
        public virtual Nsx Nsx { get; set; }
    }
}
