using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.DAL.Configs
{
    public class BonusRacialSeed : IEntityTypeConfiguration<BonusRacial>
    {
        public void Configure(EntityTypeBuilder<BonusRacial> builder)
        {
            builder.HasData(
                new BonusRacial { Id = 1, BonusName = "Dexterity", BonusValue = 2, MalusName = "Strength", MalusValue = -2 },
                new BonusRacial { Id = 2, BonusName = "Intelligence", BonusValue = 2, MalusName = "Strength", MalusValue = -2 },
                new BonusRacial { Id = 3, BonusName = "Constitution", BonusValue = 2, MalusName = "Charisma", MalusValue = -2 }
            );
        }
    }
}
