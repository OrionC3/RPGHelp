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

            builder.HasData(
                new Spell { Id = 1, Name = "Firebolt", Description = "A bolt of flame shoots from your fingertips, searing your target.\r\nDamage: 1d10 fire damage (scales with level)" },
                new Spell { Id = 2, Name = "Shadow Lance", Description = "A spear of pure shadow pierces a single enemy, ignoring armor.\r\nDamage: 2d8 necrotic damage, ignores non-magical defense." },
                new Spell { Id = 3, Name = "Shielding Ward", Description = "A shimmering barrier of force surrounds you.\r\n+5 AC until the start of your next turn." }
                );
        }
    }
}
