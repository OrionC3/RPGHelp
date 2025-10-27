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

            builder.HasOne(c => c.Users)
                .WithMany(u => u.Characteres)
                .HasForeignKey(c => c.UserId);

            builder.HasOne(c => c.Campagns)
                .WithMany(ca => ca.Characteres)
                .HasForeignKey(c => c.CampagnId);
        }
    }

}
