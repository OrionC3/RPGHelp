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
    public class BonusRacialConfig : IEntityTypeConfiguration<BonusRacial>
    {
        public void Configure(EntityTypeBuilder<BonusRacial> builder)
        {
            builder.ToTable("BonusRacial").HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();

            builder.Property(b => b.BonusName).IsRequired().HasMaxLength(100);

            builder.HasData(
                new BonusRacial { Id = 1, BonusName = "Dexterity", BonusValue = 2, MalusName = "Strength", MalusValue = -2 },
                new BonusRacial { Id = 2, BonusName = "Intelligence", BonusValue = 2, MalusName = "Strength", MalusValue = -2 },
                new BonusRacial { Id = 3, BonusName = "Constitution", BonusValue = 2, MalusName = "Charisma", MalusValue = -2 }
            );
        }
    }
}
