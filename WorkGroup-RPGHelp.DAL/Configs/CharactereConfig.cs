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
    public class CharactereConfig : IEntityTypeConfiguration<Charactere>
    {
        public void Configure(EntityTypeBuilder<Charactere> builder)
        {
            builder.ToTable("Characteres").HasKey(c => c.Id);
            builder.ToTable(c => c.HasCheckConstraint("CK_Charactere__PVMax", "PVMax > 0"));
            builder.ToTable(c => c.HasCheckConstraint("CK_Charactere__Strength", "Strength >= 0"));
            builder.ToTable(c => c.HasCheckConstraint("CK_Charactere__Dexterity", "Dexterity >= 0"));
            builder.ToTable(c => c.HasCheckConstraint("CK_Charactere__Constitution", "Constitution >= 0"));
            builder.ToTable(c => c.HasCheckConstraint("CK_Charactere__Intelligence", "Intelligence >= 0"));
            builder.ToTable(c => c.HasCheckConstraint("CK_Charactere__Wisdom", "Wisdom >= 0"));
            builder.ToTable(c => c.HasCheckConstraint("CK_Charactere__Charisma", "Charisma >= 0"));
            builder.ToTable(c => c.HasCheckConstraint("CK_Charactere__Level", "Level >= 0"));
            builder.ToTable(c => c.HasCheckConstraint("CK_Charactere__XP", "XP >= 0"));
            builder.ToTable(c => c.HasCheckConstraint("CK_Charactere__Speed", "Speed >= 0"));

            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Defence).HasDefaultValue(10);

            builder.HasData(
                // 1. Le Guerrier/Tank
                new Charactere
                {
                    Id = 1,
                    Name = "Arik le Solide",
                    IdRace = 1, // Ex: Humain
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
                    IdRace = 2, // Ex: Elfe
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
                    IdRace = 3, // Ex: Nain
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

            builder.HasOne(c => c.Users)
                .WithMany(u => u.Characteres)
                .HasForeignKey(c => c.UserId);

            builder.HasOne(c => c.Campagns)
                .WithMany(ca => ca.Characteres)
                .HasForeignKey(c => c.CampagnId);
        }
    }

}
