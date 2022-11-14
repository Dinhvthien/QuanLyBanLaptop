using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    internal class GiaTriConfigurations : IEntityTypeConfiguration<GiaTri>
    {
        public void Configure(EntityTypeBuilder<GiaTri> builder)
        {
            builder.ToTable("GiaTri");
            builder.HasKey(p => p.ID);
            builder.Property(a => a.IDThuocTinh).IsRequired();
            builder.Property(a => a.Ma).HasColumnName("Ma").HasColumnType("varchar(30)").IsRequired();
            builder.Property(a => a.ThongSo).HasColumnName("ThongSo").HasColumnType("nvarchar(50)").IsRequired();
            builder.HasOne(x => x.ThuocTinh).WithMany().HasForeignKey(a => a.IDThuocTinh);
        }
    }
}
