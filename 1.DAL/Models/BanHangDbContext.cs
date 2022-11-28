using _1.DAL.Configurations;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.Models
{
    public class BanHangDbContext : DbContext
    {
        public BanHangDbContext()
        {
        }
        public BanHangDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public virtual DbSet<CuaHang> CuaHangs { get; set; }
        public virtual DbSet<ChiTietLaptop> ChiTietLapTops { get; set; }
        public virtual DbSet<ChucVu> ChucVus { get; set; }
        public virtual DbSet<GiaTri> GiaTris { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Laptop> LapTops { get; set; }
        public virtual DbSet<MauSac> MauSacs { get; set; }
        public virtual DbSet<Nsx> NSXs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<ThuocTinh> ThuocTinhs { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }
        public virtual DbSet<Imei> Imeis { get; set; }
        public virtual DbSet<ImeiDaBan> ImeiDaBans { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring((optionsBuilder.
                UseSqlServer("Data Source=DESKTOP-3S9P0UC\\SQLEXPRESS;Initial Catalog=QuanLyBanLaptop_da1;" +
                "Persist Security Info=True;User ID=theuniverse;Password=theuniverse")));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply cac config cho cac model
            //  modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Phương thức này sẽ áp dụng tất cả các config hiện có
            modelBuilder.ApplyConfiguration(new CuaHangConfigurations());
            modelBuilder.ApplyConfiguration(new ChiTietLaptopConfigurations());
            modelBuilder.ApplyConfiguration(new ChucVuConfigurations());
            modelBuilder.ApplyConfiguration(new GiaTriConfigurations());
            modelBuilder.ApplyConfiguration(new HoaDonConfigurations());
            modelBuilder.ApplyConfiguration(new HoaDonChiTietConfigurations());
            modelBuilder.ApplyConfiguration(new KhachHangConfigurations());
            modelBuilder.ApplyConfiguration(new LaptopConfigurations());
            modelBuilder.ApplyConfiguration(new MauSacConfigurations());
            modelBuilder.ApplyConfiguration(new NsxConfigurations());
            modelBuilder.ApplyConfiguration(new NhanVienConfigurations());
            modelBuilder.ApplyConfiguration(new ThuocTinhConfigurations());
            modelBuilder.ApplyConfiguration(new VoucherConfigurations());
            modelBuilder.ApplyConfiguration(new ImeiConfigurations());
            modelBuilder.ApplyConfiguration(new ImeiDaBanConfigurations());
        }
    }
}
