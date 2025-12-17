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
                new BonusRacial { Id = 2, BonusName = "Intelligence", BonusValue = 2, MalusName = "Wisdom", MalusValue = -2 },
                new BonusRacial { Id = 3, BonusName = "Constitution", BonusValue = 2, MalusName = "Charisma", MalusValue = -2 },
                new BonusRacial { Id = 4, BonusName = "Strength", BonusValue = 2, MalusName = "Intelligence", MalusValue = -2 },
                new BonusRacial { Id = 5, BonusName = "Wisdom", BonusValue = 2, MalusName = "Dexterity", MalusValue = -2 },
                new BonusRacial { Id = 6, BonusName = "Charisma", BonusValue = 2, MalusName = "Constitution", MalusValue = -2 },
                new BonusRacial { Id = 7, BonusName = "Dexterity", BonusValue = 2, MalusName = "Charisma", MalusValue = -2 },
                new BonusRacial { Id = 8, BonusName = "Strength", BonusValue = 2, MalusName = "Wisdom", MalusValue = -2 },
                new BonusRacial { Id = 9, BonusName = "Intelligence", BonusValue = 2, MalusName = "Strength", MalusValue = -2 },
                new BonusRacial { Id = 10, BonusName = "Constitution", BonusValue = 2, MalusName = "Dexterity", MalusValue = -2 },
                new BonusRacial { Id = 11, BonusName = "Wisdom", BonusValue = 2, MalusName = "Charisma", MalusValue = -2 },
                new BonusRacial { Id = 12, BonusName = "Charisma", BonusValue = 2, MalusName = "Strength", MalusValue = -2 },
                new BonusRacial { Id = 13, BonusName = "Intelligence", BonusValue = 2, MalusName = "Constitution", MalusValue = -2 },
                new BonusRacial { Id = 14, BonusName = "Strength", BonusValue = 2, MalusName = "Dexterity", MalusValue = -2 },
                new BonusRacial { Id = 15, BonusName = "Dexterity", BonusValue = 2, MalusName = "Intelligence", MalusValue = -2 },
                new BonusRacial { Id = 16, BonusName = "Constitution", BonusValue = 2, MalusName = "Wisdom", MalusValue = -2 },
                new BonusRacial { Id = 17, BonusName = "Wisdom", BonusValue = 2, MalusName = "Strength", MalusValue = -2 },
                new BonusRacial { Id = 18, BonusName = "Charisma", BonusValue = 2, MalusName = "Intelligence", MalusValue = -2 },
                new BonusRacial { Id = 19, BonusName = "Strength", BonusValue = 2, MalusName = "Constitution", MalusValue = -2 },
                new BonusRacial { Id = 20, BonusName = "Dexterity", BonusValue = 2, MalusName = "Wisdom", MalusValue = -2 },
                new BonusRacial { Id = 21, BonusName = "Intelligence", BonusValue = 2, MalusName = "Charisma", MalusValue = -2 },
                new BonusRacial { Id = 22, BonusName = "Constitution", BonusValue = 2, MalusName = "Strength", MalusValue = -2 },
                new BonusRacial { Id = 23, BonusName = "Wisdom", BonusValue = 2, MalusName = "Intelligence", MalusValue = -2 }
            );
        }
    }
}
