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
    public class RaceConfig : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            builder.ToTable("Race").HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();

            builder.HasIndex(r => r.Name).IsUnique();
            builder.Property(r => r.Name).IsRequired().HasMaxLength(255);

            builder.HasOne(r => r.BonusRacial)
                   .WithOne(b => b.Race)
                   .HasForeignKey<Race>(j => j.BonusRacialId);

            builder.HasMany(r => r.Spells).WithMany(o => o.Races);
        }
    }
}
