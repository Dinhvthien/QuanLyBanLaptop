using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    internal class ChiTietLaptopConfigurations : IEntityTypeConfiguration<ChiTietLaptop>
    {
        public void Configure(EntityTypeBuilder<ChiTietLaptop> builder)
        {
            builder.ToTable("ChiTietLaptop");
            builder.HasKey(p => p.ID);
            builder.Property(p => p.Ma).HasColumnName("Ma").HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.IDMauSac).IsRequired();
            builder.Property(p => p.IDNsx).IsRequired();
            builder.Property(p => p.IDLaptop).IsRequired();
            builder.Property(p => p.MoTa).HasColumnName("Mota").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(p => p.SoLuong).HasColumnName("SoLuong").HasColumnType("int").IsRequired();
            builder.Property(p => p.GiaNhap).HasColumnName("GiaNhap").HasColumnType("money").IsRequired();
            builder.Property(p => p.Giaban).HasColumnName("GiaBan").HasColumnType("money").IsRequired();
            builder.HasOne(x => x.MauSac).WithMany().HasForeignKey(x => x.IDMauSac);
            builder.HasOne(x => x.Nsx).WithMany().HasForeignKey(x => x.IDNsx);
            builder.HasOne(x => x.Laptop).WithMany().HasForeignKey(x => x.IDLaptop);
        }
    }
}
