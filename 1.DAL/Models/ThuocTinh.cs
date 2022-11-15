namespace _1.DAL.Models
{
    public class ThuocTinh
    {
        public Guid ID { get; set; }
        public Guid IDLaptop { get; set; }
        public string Ten { get; set; }
        public string Ma { get; set; }
        public virtual Laptop Laptop { get; set; }
    }
}
