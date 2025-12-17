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
                    Initiative = 1,
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
                    BaseAttackBonus = 1,
                    FortitudeSave = 1,
                    ReflexeSave = 6, // Excellent JDS Réflexe
                    WillpowerSave = 2,
                    Level = 1,
                    XP = 1,
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
                    WillpowerSave = 1,
                    Level = 1,
                    XP = 1,
                    Speed = 20, // Les Nains sont souvent plus lents
                    UserId = 1,
                    CampagnId = 2,
                },
                new Charactere { Id = 4, Name = "Valerius le Sage", RaceId = 15, PVMax = 9, PVCurrent = 9, Strength = 8, Dexterity = 12, Constitution = 12, Intelligence = 14, Wisdom = 18, Charisma = 13, Defence = 12, Initiative = 1, BaseAttackBonus = 1, FortitudeSave = 1, ReflexeSave = 1, WillpowerSave = 5, Level = 1, XP = 1, Speed = 30, UserId = 3, CampagnId = 1 },
                new Charactere { Id = 5, Name = "Zog l'Éclatant", RaceId = 6, PVMax = 13, PVCurrent = 13, Strength = 18, Dexterity = 12, Constitution = 14, Intelligence = 7, Wisdom = 10, Charisma = 15, Defence = 16, Initiative = 1, BaseAttackBonus = 1, FortitudeSave = 4, ReflexeSave = 1, WillpowerSave = 2, Level = 1, XP = 1, Speed = 30, UserId = 4, CampagnId = 1 },
                new Charactere { Id = 6, Name = "Lirael de la Rose", RaceId = 1, PVMax = 8, PVCurrent = 8, Strength = 7, Dexterity = 16, Constitution = 10, Intelligence = 18, Wisdom = 12, Charisma = 14, Defence = 13, Initiative = 3, BaseAttackBonus = 1, FortitudeSave = 1, ReflexeSave = 3, WillpowerSave = 4, Level = 1, XP = 1, Speed = 30, UserId = 2, CampagnId = 2 },
                new Charactere { Id = 7, Name = "Thokk le Briseur", RaceId = 9, PVMax = 15, PVCurrent = 15, Strength = 17, Dexterity = 13, Constitution = 18, Intelligence = 8, Wisdom = 9, Charisma = 7, Defence = 15, Initiative = 1, BaseAttackBonus = 2, FortitudeSave = 6, ReflexeSave = 1, WillpowerSave = 1, Level = 2, XP = 1200, Speed = 30, UserId = 3, CampagnId = 2 },
                new Charactere { Id = 8, Name = "Faelar Vent-Léger", RaceId = 10, PVMax = 11, PVCurrent = 11, Strength = 10, Dexterity = 19, Constitution = 12, Intelligence = 11, Wisdom = 14, Charisma = 13, Defence = 14, Initiative = 4, BaseAttackBonus = 1, FortitudeSave = 1, ReflexeSave = 5, WillpowerSave = 2, Level = 1, XP = 500, Speed = 40, UserId = 4, CampagnId = null },
                new Charactere { Id = 9, Name = "Grimm de Pierre", RaceId = 4, PVMax = 22, PVCurrent = 18, Strength = 15, Dexterity = 11, Constitution = 17, Intelligence = 9, Wisdom = 13, Charisma = 8, Defence = 18, Initiative = 1, BaseAttackBonus = 2, FortitudeSave = 5, ReflexeSave = 1, WillpowerSave = 3, Level = 2, XP = 1500, Speed = 20, UserId = 2, CampagnId = 2 },
                new Charactere { Id = 10, Name = "Sly l'Ombre", RaceId = 5, PVMax = 9, PVCurrent = 9, Strength = 9, Dexterity = 18, Constitution = 13, Intelligence = 12, Wisdom = 10, Charisma = 16, Defence = 15, Initiative = 4, BaseAttackBonus = 1, FortitudeSave = 2, ReflexeSave = 6, WillpowerSave = 1, Level = 1, XP = 1, Speed = 25, UserId = 1, CampagnId = 3 },
                new Charactere { Id = 11, Name = "Mala la Rouge", RaceId = 21, PVMax = 10, PVCurrent = 10, Strength = 10, Dexterity = 14, Constitution = 14, Intelligence = 17, Wisdom = 11, Charisma = 12, Defence = 12, Initiative = 2, BaseAttackBonus = 1, FortitudeSave = 2, ReflexeSave = 2, WillpowerSave = 4, Level = 1, XP = 1, Speed = 30, UserId = 2, CampagnId = 3 },
                new Charactere { Id = 12, Name = "Korg l'Ancien", RaceId = 23, PVMax = 14, PVCurrent = 14, Strength = 14, Dexterity = 8, Constitution = 15, Intelligence = 10, Wisdom = 16, Charisma = 9, Defence = 17, Initiative = 1, BaseAttackBonus = 1, FortitudeSave = 4, ReflexeSave = 1, WillpowerSave = 5, Level = 1, XP = 1, Speed = 20, UserId = 3, CampagnId = 3 },
                new Charactere { Id = 13, Name = "Vesper", RaceId = 8, PVMax = 12, PVCurrent = 12, Strength = 11, Dexterity = 15, Constitution = 12, Intelligence = 13, Wisdom = 10, Charisma = 18, Defence = 13, Initiative = 2, BaseAttackBonus = 1, FortitudeSave = 1, ReflexeSave = 3, WillpowerSave = 4, Level = 1, XP = 1, Speed = 30, UserId = 4, CampagnId = 3 },
                new Charactere { Id = 14, Name = "Orik du Pic", RaceId = 12, PVMax = 16, PVCurrent = 16, Strength = 19, Dexterity = 12, Constitution = 16, Intelligence = 8, Wisdom = 11, Charisma = 10, Defence = 16, Initiative = 1, BaseAttackBonus = 1, FortitudeSave = 5, ReflexeSave = 1, WillpowerSave = 1, Level = 1, XP = 1, Speed = 30, UserId = 1, CampagnId = 3 },
                new Charactere { Id = 15, Name = "Nalia l'Astucieuse", RaceId = 7, PVMax = 8, PVCurrent = 8, Strength = 8, Dexterity = 14, Constitution = 12, Intelligence = 19, Wisdom = 13, Charisma = 11, Defence = 12, Initiative = 2, BaseAttackBonus = 1, FortitudeSave = 1, ReflexeSave = 2, WillpowerSave = 3, Level = 1, XP = 1, Speed = 25, UserId = 2, CampagnId = 3 },
                new Charactere { Id = 16, Name = "Skree", RaceId = 13, PVMax = 9, PVCurrent = 9, Strength = 10, Dexterity = 17, Constitution = 11, Intelligence = 14, Wisdom = 15, Charisma = 8, Defence = 14, Initiative = 3, BaseAttackBonus = 1, FortitudeSave = 1, ReflexeSave = 5, WillpowerSave = 2, Level = 1, XP = 1, Speed = 30, UserId = 3, CampagnId = 3 },
                new Charactere { Id = 17, Name = "Borg l'Étourdi", RaceId = 17, PVMax = 18, PVCurrent = 18, Strength = 18, Dexterity = 14, Constitution = 15, Intelligence = 7, Wisdom = 8, Charisma = 9, Defence = 15, Initiative = 2, BaseAttackBonus = 2, FortitudeSave = 4, ReflexeSave = 3, WillpowerSave = 1, Level = 2, XP = 1100, Speed = 30, UserId = 4, CampagnId = 3 },
                new Charactere { Id = 18, Name = "Sarya la Pure", RaceId = 15, PVMax = 10, PVCurrent = 10, Strength = 12, Dexterity = 12, Constitution = 12, Intelligence = 11, Wisdom = 15, Charisma = 17, Defence = 14, Initiative = 1, BaseAttackBonus = 1, FortitudeSave = 3, ReflexeSave = 1, WillpowerSave = 5, Level = 1, XP = 200, Speed = 30, UserId = 1, CampagnId = 3 },
                new Charactere { Id = 19, Name = "Xil", RaceId = 19, PVMax = 11, PVCurrent = 11, Strength = 11, Dexterity = 14, Constitution = 13, Intelligence = 18, Wisdom = 12, Charisma = 15, Defence = 12, Initiative = 2, BaseAttackBonus = 1, FortitudeSave = 1, ReflexeSave = 2, WillpowerSave = 4, Level = 1, XP = 1, Speed = 30, UserId = 2, CampagnId = 3 },
                new Charactere { Id = 20, Name = "Durgan le Hardi", RaceId = 4, PVMax = 28, PVCurrent = 28, Strength = 16, Dexterity = 10, Constitution = 18, Intelligence = 10, Wisdom = 12, Charisma = 10, Defence = 19, Initiative = 1, BaseAttackBonus = 3, FortitudeSave = 7, ReflexeSave = 2, WillpowerSave = 4, Level = 3, XP = 3000, Speed = 20, UserId = 3, CampagnId = 3 },
                new Charactere { Id = 21, Name = "Luth l'Errant", RaceId = 11, PVMax = 13, PVCurrent = 13, Strength = 15, Dexterity = 11, Constitution = 14, Intelligence = 10, Wisdom = 17, Charisma = 12, Defence = 14, Initiative = 1, BaseAttackBonus = 1, FortitudeSave = 4, ReflexeSave = 1, WillpowerSave = 5, Level = 1, XP = 1, Speed = 30, UserId = 4, CampagnId = 3 },
                new Charactere { Id = 22, Name = "Meepo", RaceId = 18, PVMax = 7, PVCurrent = 7, Strength = 7, Dexterity = 18, Constitution = 10, Intelligence = 10, Wisdom = 8, Charisma = 12, Defence = 15, Initiative = 4, BaseAttackBonus = 1, FortitudeSave = 1, ReflexeSave = 4, WillpowerSave = 1, Level = 1, XP = 50, Speed = 30, UserId = 1, CampagnId = 3 },
                new Charactere { Id = 23, Name = "Zyrk l'Agile", RaceId = 10, PVMax = 12, PVCurrent = 12, Strength = 12, Dexterity = 20, Constitution = 13, Intelligence = 11, Wisdom = 11, Charisma = 14, Defence = 16, Initiative = 5, BaseAttackBonus = 2, FortitudeSave = 2, ReflexeSave = 6, WillpowerSave = 2, Level = 2, XP = 1350, Speed = 40, UserId = 2, CampagnId = 3 },
                new Charactere { Id = 24, Name = "Thokk le Briseur", RaceId = 9, PVMax = 15, PVCurrent = 15, Strength = 18, Dexterity = 12, Constitution = 16, Intelligence = 8, Wisdom = 10, Charisma = 8, Defence = 16, Initiative = 1, BaseAttackBonus = 1, FortitudeSave = 5, ReflexeSave = 1, WillpowerSave = 1, Level = 1, XP = 1, Speed = 30, UserId = 3, CampagnId = 1 },
                new Charactere { Id = 25, Name = "Lirael de l'Aube", RaceId = 15, PVMax = 9, PVCurrent = 9, Strength = 8, Dexterity = 14, Constitution = 12, Intelligence = 14, Wisdom = 16, Charisma = 12, Defence = 13, Initiative = 2, BaseAttackBonus = 1, FortitudeSave = 1, ReflexeSave = 2, WillpowerSave = 5, Level = 1, XP = 1, Speed = 30, UserId = 4, CampagnId = 2 },
                new Charactere { Id = 26, Name = "Gimble l'Inventeur", RaceId = 7, PVMax = 8, PVCurrent = 8, Strength = 6, Dexterity = 15, Constitution = 12, Intelligence = 18, Wisdom = 10, Charisma = 13, Defence = 13, Initiative = 2, BaseAttackBonus = 1, FortitudeSave = 1, ReflexeSave = 3, WillpowerSave = 2, Level = 1, XP = 10, Speed = 25, UserId = 1, CampagnId = 3 },
                new Charactere { Id = 27, Name = "Kriv l'Écaillé", RaceId = 6, PVMax = 13, PVCurrent = 13, Strength = 17, Dexterity = 10, Constitution = 14, Intelligence = 10, Wisdom = 11, Charisma = 14, Defence = 15, Initiative = 1, BaseAttackBonus = 1, FortitudeSave = 4, ReflexeSave = 1, WillpowerSave = 1, Level = 1, XP = 1, Speed = 30, UserId = 2, CampagnId = null },
                new Charactere { Id = 28, Name = "Zariel l'Ombre", RaceId = 8, PVMax = 10, PVCurrent = 10, Strength = 10, Dexterity = 16, Constitution = 12, Intelligence = 13, Wisdom = 8, Charisma = 17, Defence = 14, Initiative = 3, BaseAttackBonus = 1, FortitudeSave = 1, ReflexeSave = 4, WillpowerSave = 2, Level = 1, XP = 1, Speed = 30, UserId = 3, CampagnId = 2 },
                new Charactere { Id = 29, Name = "Orog le Montagnard", RaceId = 12, PVMax = 16, PVCurrent = 16, Strength = 19, Dexterity = 10, Constitution = 15, Intelligence = 8, Wisdom = 12, Charisma = 9, Defence = 14, Initiative = 1, BaseAttackBonus = 1, FortitudeSave = 6, ReflexeSave = 1, WillpowerSave = 1, Level = 1, XP = 50, Speed = 30, UserId = 4, CampagnId = 3 },
                new Charactere { Id = 30, Name = "Mew-Mew la Agile", RaceId = 10, PVMax = 11, PVCurrent = 11, Strength = 10, Dexterity = 19, Constitution = 12, Intelligence = 11, Wisdom = 12, Charisma = 14, Defence = 15, Initiative = 4, BaseAttackBonus = 1, FortitudeSave = 2, ReflexeSave = 6, WillpowerSave = 1, Level = 1, XP = 1, Speed = 40, UserId = 1, CampagnId = 1 },
                new Charactere { Id = 31, Name = "Vark l'Espion", RaceId = 13, PVMax = 9, PVCurrent = 9, Strength = 8, Dexterity = 17, Constitution = 13, Intelligence = 14, Wisdom = 12, Charisma = 8, Defence = 14, Initiative = 3, BaseAttackBonus = 1, FortitudeSave = 1, ReflexeSave = 5, WillpowerSave = 3, Level = 1, XP = 1, Speed = 30, UserId = 2, CampagnId = null },
                new Charactere { Id = 32, Name = "Sss'Kala", RaceId = 14, PVMax = 14, PVCurrent = 14, Strength = 14, Dexterity = 12, Constitution = 17, Intelligence = 10, Wisdom = 13, Charisma = 8, Defence = 16, Initiative = 1, BaseAttackBonus = 1, FortitudeSave = 5, ReflexeSave = 2, WillpowerSave = 3, Level = 1, XP = 1, Speed = 30, UserId = 3, CampagnId = 2 },
                new Charactere { Id = 33, Name = "Hark l'Imposant", RaceId = 17, PVMax = 13, PVCurrent = 13, Strength = 18, Dexterity = 14, Constitution = 14, Intelligence = 9, Wisdom = 10, Charisma = 11, Defence = 14, Initiative = 2, BaseAttackBonus = 1, FortitudeSave = 4, ReflexeSave = 3, WillpowerSave = 1, Level = 1, XP = 20, Speed = 30, UserId = 4, CampagnId = 1 },
                new Charactere { Id = 34, Name = "Meepo le Chanceux", RaceId = 18, PVMax = 7, PVCurrent = 7, Strength = 6, Dexterity = 18, Constitution = 12, Intelligence = 10, Wisdom = 8, Charisma = 12, Defence = 15, Initiative = 4, BaseAttackBonus = 1, FortitudeSave = 1, ReflexeSave = 5, WillpowerSave = 1, Level = 1, XP = 1, Speed = 30, UserId = 1, CampagnId = 2 },
                new Charactere { Id = 35, Name = "Xiloscient", RaceId = 4, PVMax = 15, PVCurrent = 15, Strength = 14, Dexterity = 10, Constitution = 18, Intelligence = 12, Wisdom = 14, Charisma = 8, Defence = 17, Initiative = 1, BaseAttackBonus = 1, FortitudeSave = 6, ReflexeSave = 1, WillpowerSave = 3, Level = 1, XP = 1, Speed = 25, UserId = 2, CampagnId = 3 },
                new Charactere { Id = 36, Name = "Sylas le Savant", RaceId = 19, PVMax = 10, PVCurrent = 10, Strength = 8, Dexterity = 13, Constitution = 12, Intelligence = 19, Wisdom = 14, Charisma = 15, Defence = 12, Initiative = 1, BaseAttackBonus = 1, FortitudeSave = 1, ReflexeSave = 2, WillpowerSave = 4, Level = 1, XP = 1, Speed = 30, UserId = 3, CampagnId = null },
                new Charactere { Id = 37, Name = "Pebble", RaceId = 20, PVMax = 14, PVCurrent = 14, Strength = 17, Dexterity = 10, Constitution = 16, Intelligence = 10, Wisdom = 11, Charisma = 8, Defence = 15, Initiative = 1, BaseAttackBonus = 1, FortitudeSave = 5, ReflexeSave = 1, WillpowerSave = 1, Level = 1, XP = 1, Speed = 30, UserId = 4, CampagnId = 1 },
                new Charactere { Id = 38, Name = "Ignis", RaceId = 21, PVMax = 11, PVCurrent = 11, Strength = 10, Dexterity = 14, Constitution = 14, Intelligence = 17, Wisdom = 10, Charisma = 12, Defence = 13, Initiative = 2, BaseAttackBonus = 1, FortitudeSave = 3, ReflexeSave = 3, WillpowerSave = 1, Level = 1, XP = 1, Speed = 30, UserId = 1, CampagnId = 3 },
                new Charactere { Id = 39, Name = "Pan le Joyeux", RaceId = 22, PVMax = 12, PVCurrent = 12, Strength = 12, Dexterity = 16, Constitution = 11, Intelligence = 10, Wisdom = 12, Charisma = 18, Defence = 14, Initiative = 3, BaseAttackBonus = 1, FortitudeSave = 1, ReflexeSave = 4, WillpowerSave = 2, Level = 1, XP = 5, Speed = 35, UserId = 2, CampagnId = 2 },
                new Charactere { Id = 40, Name = "Shelly la Lente", RaceId = 23, PVMax = 13, PVCurrent = 13, Strength = 15, Dexterity = 8, Constitution = 15, Intelligence = 10, Wisdom = 17, Charisma = 10, Defence = 18, Initiative = 1, BaseAttackBonus = 1, FortitudeSave = 4, ReflexeSave = 1, WillpowerSave = 5, Level = 1, XP = 1, Speed = 30, UserId = 3, CampagnId = 1 },
                new Charactere { Id = 41, Name = "Korth le Cruel", RaceId = 16, PVMax = 12, PVCurrent = 12, Strength = 14, Dexterity = 12, Constitution = 14, Intelligence = 16, Wisdom = 10, Charisma = 12, Defence = 15, Initiative = 1, BaseAttackBonus = 1, FortitudeSave = 4, ReflexeSave = 2, WillpowerSave = 1, Level = 1, XP = 1, Speed = 30, UserId = 4, CampagnId = null },
                new Charactere { Id = 42, Name = "Finn le Petit", RaceId = 5, PVMax = 9, PVCurrent = 9, Strength = 8, Dexterity = 19, Constitution = 13, Intelligence = 10, Wisdom = 12, Charisma = 14, Defence = 16, Initiative = 4, BaseAttackBonus = 1, FortitudeSave = 2, ReflexeSave = 6, WillpowerSave = 2, Level = 1, XP = 1, Speed = 25, UserId = 1, CampagnId = null },
                new Charactere { Id = 43, Name = "Durn le Sage", RaceId = 11, PVMax = 12, PVCurrent = 12, Strength = 16, Dexterity = 8, Constitution = 14, Intelligence = 10, Wisdom = 18, Charisma = 11, Defence = 13, Initiative = 1, BaseAttackBonus = 1, FortitudeSave = 4, ReflexeSave = 1, WillpowerSave = 6, Level = 1, XP = 1, Speed = 30, UserId = 2, CampagnId = 1 }
            );
        }
    }

}
