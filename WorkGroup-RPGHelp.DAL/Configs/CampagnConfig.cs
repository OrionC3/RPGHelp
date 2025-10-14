using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.DAL.Configs
{
    public class CampagnConfig : IEntityTypeConfiguration<Campagn>
    {
        public void Configure(EntityTypeBuilder<Campagn> builder)
        {
            builder.ToTable("Campagn").HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();

            builder.HasIndex(r => r.Name).IsUnique();
            builder.Property(r => r.Name).IsRequired().HasMaxLength(50);

            builder.HasData(
                new Role { Id = 1, Name = "Ma première Campagne" },
                new Role { Id = 2, Name = "True Story" },
                new Role { Id = 3, Name = "Dragon First" }
            );
        }
    }
}
