using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    internal class KhachHangConfigurations : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.ToTable("KhachHang");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.SDT).HasColumnName("SDT").HasColumnType("varchar(15)").IsRequired();
            builder.Property(a => a.HoTen).HasColumnName("HoTen").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(a => a.DiaChi).HasColumnName("DiaChi").HasColumnType("nvarchar(50)").IsRequired();
        }
    }
}
