using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    internal class ThuocTinhConfigurations : IEntityTypeConfiguration<ThuocTinh>
    {
        public void Configure(EntityTypeBuilder<ThuocTinh> builder)
        {
            builder.ToTable("ThuocTinh");
            builder.HasKey(p => p.ID);
            builder.Property(a => a.IDLaptop).IsRequired();
            builder.Property(a => a.Ma).HasColumnName("Ma").HasColumnType("varchar(30)").IsRequired();
            builder.Property(a => a.Ten).HasColumnName("Ten").HasColumnType("nvarchar(50)").IsRequired();
            builder.HasOne(x => x.Laptop).WithMany().HasForeignKey(a => a.IDLaptop);
        }
    }
}
