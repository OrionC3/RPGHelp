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
    public class SpellConfig : IEntityTypeConfiguration<Spell>
    {
        public void Configure(EntityTypeBuilder<Spell> builder)
        {
            builder.ToTable("Spell").HasKey(s => s.Id);
            builder.Property(s => s.Id).ValueGeneratedOnAdd();

            builder.HasIndex(s => s.Name).IsUnique();
            builder.Property(s => s.Name).IsRequired().HasMaxLength(50);

            builder.HasMany(s => s.Races)
                   .WithMany(o => o.Spells);
        }
    }
}
