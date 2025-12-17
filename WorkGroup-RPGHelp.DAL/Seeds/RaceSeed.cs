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
    public class RaceSeed : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            builder.HasData(
                new Race { Id = 1, Name = "Elf", BonusRacialId = 1 },
                new Race { Id = 2, Name = "Orc", BonusRacialId = 2 },
                new Race { Id = 3, Name = "Half Elf", BonusRacialId = 3 },
                new Race { Id = 4, Name = "Dwarf", BonusRacialId = 16 },       // Bonus Constitution / Malus Wisdom
                new Race { Id = 5, Name = "Halfling", BonusRacialId = 7 },    // Bonus Dexterity / Malus Charisma
                new Race { Id = 6, Name = "Dragonborn", BonusRacialId = 4 },  // Bonus Strength / Malus Intelligence
                new Race { Id = 7, Name = "Gnome", BonusRacialId = 9 },       // Bonus Intelligence / Malus Strength
                new Race { Id = 8, Name = "Tiefling", BonusRacialId = 18 },   // Bonus Charisma / Malus Intelligence
                new Race { Id = 9, Name = "Half-Orc", BonusRacialId = 22 },   // Bonus Constitution / Malus Strength
                new Race { Id = 10, Name = "Tabaxi", BonusRacialId = 15 },    // Bonus Dexterity / Malus Intelligence
                new Race { Id = 11, Name = "Firbolg", BonusRacialId = 5 },    // Bonus Wisdom / Malus Dexterity
                new Race { Id = 12, Name = "Goliath", BonusRacialId = 19 },   // Bonus Strength / Malus Constitution
                new Race { Id = 13, Name = "Kenku", BonusRacialId = 20 },     // Bonus Dexterity / Malus Wisdom
                new Race { Id = 14, Name = "Lizardfolk", BonusRacialId = 10 },// Bonus Constitution / Malus Dexterity
                new Race { Id = 15, Name = "Aasimar", BonusRacialId = 11 },   // Bonus Wisdom / Malus Charisma
                new Race { Id = 16, Name = "Hobgoblin", BonusRacialId = 13 }, // Bonus Intelligence / Malus Constitution
                new Race { Id = 17, Name = "Bugbear", BonusRacialId = 14 },   // Bonus Strength / Malus Dexterity
                new Race { Id = 18, Name = "Kobold", BonusRacialId = 23 },     // Bonus Dexterity / Malus Strength
                new Race { Id = 19, Name = "Yuan-ti", BonusRacialId = 21 },   // Bonus Intelligence / Malus Charisma
                new Race { Id = 20, Name = "Genasi (Earth)", BonusRacialId = 8 }, // Bonus Strength / Malus Wisdom
                new Race { Id = 21, Name = "Genasi (Fire)", BonusRacialId = 12 },  // Bonus Intelligence / Malus Wisdom
                new Race { Id = 22, Name = "Satyr", BonusRacialId = 6 },      // Bonus Charisma / Malus Constitution
                new Race { Id = 23, Name = "Tortle", BonusRacialId = 17 }     // Bonus Wisdom / Malus Strength
            );
        }
    }
}
