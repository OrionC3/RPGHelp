using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.DAL.Configs
{
    public class CampagnConfig : IEntityTypeConfiguration<Campagn>
    {
        public void Configure(EntityTypeBuilder<Campagn> builder)
        {
            builder.ToTable("Campagn").HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.HasIndex(c => c.Name).IsUnique();
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);

            builder.HasMany(c => c.Characteres)
                .WithOne(ch => ch.Campagns);
        }
    }
}
