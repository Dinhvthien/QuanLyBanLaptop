using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    internal class ImeiConfigurations : IEntityTypeConfiguration<Imei>
    {
        public void Configure(EntityTypeBuilder<Imei> builder)
        {
            builder.ToTable("Imei");
            builder.HasKey(p => p.ID);
            builder.Property(a => a.IDChiTietLaptop).IsRequired();
            builder.Property(a => a.SoEmei).HasColumnName("SoImei").HasColumnType("varchar(70)").IsRequired();
            builder.HasOne(x => x.ChiTietLaptop).WithMany().HasForeignKey(a => a.IDChiTietLaptop);
        }
    }
}
