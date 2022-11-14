using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    internal class CuaHangConfigurations : IEntityTypeConfiguration<CuaHang>
    {
        public void Configure(EntityTypeBuilder<CuaHang> builder)
        {
            builder.ToTable("CuaHang");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.Sdt).HasColumnName("SDT").HasColumnType("varchar(15)").IsRequired();
            builder.Property(a => a.Ma).HasColumnName("Ma").HasColumnType("varchar(30)").IsRequired();
            builder.Property(a => a.Ten).HasColumnName("TenCuaHang").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(a => a.DiaChi).HasColumnName("DiaChi").HasColumnType("nvarchar(50)").IsRequired();
        }
    }
}
