using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    internal class HoaDonChiTietConfigurations : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");
            builder.HasKey(x => new { x.IDHoaDon, x.IDChiTietLapTop });
            builder.Property(p => p.SoLuong).HasColumnName("SoLuong").HasColumnType("int").IsRequired();
            builder.Property(p => p.GiaTruoc).HasColumnName("GiaTruoc").HasColumnType("money").IsRequired();
            builder.Property(p => p.GiaSauKhiGiam).HasColumnName("GiaSauKhiGiam").HasColumnType("money").IsRequired();
            builder.Property(p => p.NgayTao).HasColumnName("NgayTao").HasColumnType("datetime").IsRequired();
            builder.HasOne(p => p.ChiTietLaptop).WithMany().HasForeignKey(p => p.IDChiTietLapTop);
            builder.HasOne(p => p.HoaDon).WithMany().HasForeignKey(p => p.IDHoaDon);
        }
    }
}
