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
    public class SpellSeed : IEntityTypeConfiguration<Spell>
    {
        public void Configure(EntityTypeBuilder<Spell> builder)
        {

            builder.HasData(
                new Spell { Id = 1, Name = "Firebolt", Description = "A bolt of flame shoots from your fingertips, searing your target.\r\nDamage: 1d10 fire damage (scales with level)" },
                new Spell { Id = 2, Name = "Shadow Lance", Description = "A spear of pure shadow pierces a single enemy, ignoring armor.\r\nDamage: 2d8 necrotic damage, ignores non-magical defense." },
                new Spell { Id = 3, Name = "Shielding Ward", Description = "A shimmering barrier of force surrounds you.\r\n+5 AC until the start of your next turn." }
                );
        }
    }
}
