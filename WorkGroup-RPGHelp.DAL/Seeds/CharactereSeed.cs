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
    public class CharactereSeed: IEntityTypeConfiguration<Charactere>
    {
        public void Configure(EntityTypeBuilder<Charactere> builder)
        {
            builder.HasData(
                // 1. Le Guerrier/Tank
                new Charactere
                {
                    Id = 1,
                    Name = "Arik le Solide",
                    RaceId = 1, // Ex: Humain
                    PVMax = 12,
                    PVCurrent = 12,
                    Strength = 16,
                    Dexterity = 10,
                    Constitution = 14,
                    Intelligence = 8,
                    Wisdom = 12,
                    Charisma = 10,
                    Defence = 17,
                    Initiative = 0,
                    BaseAttackBonus = 1,
                    FortitudeSave = 4,
                    ReflexeSave = 0,
                    WillpowerSave = 1,
                    Level = 1,
                    XP = 0,
                    Speed = 30,
                    UserId = 1,
                    CampagnId = 1,
                },
                new Charactere
                {
                    Id = 2,
                    Name = "Elara la Furtive",
                    RaceId = 2, // Ex: Elfe
                    PVMax = 10,
                    PVCurrent = 10,
                    Strength = 10,
                    Dexterity = 18, // Haute Dextérité
                    Constitution = 12,
                    Intelligence = 10,
                    Wisdom = 14, // Bonne Sagesse
                    Charisma = 8,
                    Defence = 15,
                    Initiative = 4, // Basée sur la Dextérité
                    BaseAttackBonus = 0,
                    FortitudeSave = 1,
                    ReflexeSave = 6, // Excellent JDS Réflexe
                    WillpowerSave = 2,
                    Level = 1,
                    XP = 0,
                    Speed = 30,
                    UserId = 2,
                    CampagnId = 1,
                },
                new Charactere
                {
                    Id = 3,
                    Name = "Borin Pied-de-Fer",
                    RaceId = 3, // Ex: Nain
                    PVMax = 14,
                    PVCurrent = 14,
                    Strength = 14,
                    Dexterity = 12,
                    Constitution = 16, // Haute Constitution
                    Intelligence = 10,
                    Wisdom = 10,
                    Charisma = 8,
                    Defence = 16,
                    Initiative = 1,
                    BaseAttackBonus = 1,
                    FortitudeSave = 5,
                    ReflexeSave = 1,
                    WillpowerSave = 0,
                    Level = 1,
                    XP = 0,
                    Speed = 20, // Les Nains sont souvent plus lents
                    UserId = 1,
                    CampagnId = 2,
                }
            );
        }
    }

}
