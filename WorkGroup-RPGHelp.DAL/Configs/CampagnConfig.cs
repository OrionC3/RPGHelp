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

            builder.HasData(
                new Campagn { Id = 1, Name = "Ma première Campagne" , Description = "Chapter 4 finished", IsFinish = false, IdGM = 1},
                new Campagn { Id = 2, Name = "True Story", Description = "Chapter 2 started", IsFinish = false, IdGM = 2 },
                new Campagn { Id = 3, Name = "Dragon First", IsFinish = false, IdGM = 1 }
            );

            builder.HasMany(c => c.Characteres)
                .WithOne(ch => ch.Campagns);
        }
    }
}
