using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1.DAL.Configurations
{
    internal class NsxConfigurations : IEntityTypeConfiguration<Nsx>
    {
        public void Configure(EntityTypeBuilder<Nsx> builder)
        {
            builder.ToTable("NhaSanXuat");
            builder.HasKey(a => a.ID);
            builder.Property(a => a.Ma).HasColumnName("Ma").HasColumnType("varchar(30)").IsRequired();
            builder.Property(a => a.Ten).HasColumnName("Ten").HasColumnType("nvarchar(50)").IsRequired();
        }
    }
}
