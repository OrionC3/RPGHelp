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
                new Race { Id = 3, Name = "Half Elf", BonusRacialId = 3 }
            );
        }
    }
}
