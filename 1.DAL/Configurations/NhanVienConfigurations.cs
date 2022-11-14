
using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    internal class NhanVienConfigurations : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.IdChucVu).IsRequired();
            builder.Property(a => a.IdCuaHang).IsRequired();
            builder.Property(a => a.Ma).HasColumnName("Ma").HasColumnType("varchar(30)").IsRequired();
            builder.Property(a => a.SDT).HasColumnName("SDT").HasColumnType("varchar(15)").IsRequired();
            builder.Property(a => a.HoTen).HasColumnName("HoTen").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(a => a.DiaChi).HasColumnName("DiaChi").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(a => a.MatKhau).HasColumnName("MatKhau").HasColumnType("varchar(50)").IsRequired();
            builder.Property(a => a.TrangThai).HasColumnName("TrangThai").HasColumnType("nvarchar(50)").IsRequired();
            builder.HasOne(x => x.CuaHang).WithMany().HasForeignKey(a => a.IdCuaHang);
            builder.HasOne(x => x.ChucVu).WithMany().HasForeignKey(a => a.IdChucVu);
        }
    }
}
