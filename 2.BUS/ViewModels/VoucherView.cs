namespace _2.BUS.ViewModels
{
    public class VoucherView
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
