using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.DAL.Configs
{
    public class CampagnSeed : IEntityTypeConfiguration<Campagn>
    {
        public void Configure(EntityTypeBuilder<Campagn> builder)
        {
            builder.HasData(
                new Campagn { Id = 1, Name = "Ma première Campagne", Description = "Chapter 4 finished", IsFinish = false, IdGM = 1 },
                new Campagn { Id = 2, Name = "True Story", Description = "Chapter 2 started", IsFinish = false, IdGM = 2 },
                new Campagn { Id = 3, Name = "Dragon First", IsFinish = false, IdGM = 1 }
            );

            builder.HasMany(c => c.Users)
                .WithMany(u => u.Campagns).UsingEntity(j => j.HasData(
                    new { UsersId = 1, CampagnsId = 1 },
                    new { UsersId = 1, CampagnsId = 2 },
                    new { UsersId = 2, CampagnsId = 1 }
                    ));
        }
    }
}
