using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.DAL.Configs
{
    public class UserSeed : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasData(new Users { Id = 1, Email = "fabian@test.com", Password = "$argon2id$v=19$m=65536,t=3,p=1$LHZG57rDMJ+sJvIkpI3Jqw$XXx4Ov08UZCFXAOoP+kZTmpI9MVfnJkZ5lP77JNgt/s" });
            builder.HasData(new Users { Id = 2, Email = "mathieu@test.com", Password = "$argon2id$v=19$m=65536,t=3,p=1$LHZG57rDMJ+sJvIkpI3Jqw$XXx4Ov08UZCFXAOoP+kZTmpI9MVfnJkZ5lP77JNgt/s" });
            builder.HasData(new Users { Id = 3, Email = "user@example.com", Password = "$argon2id$v=19$m=65536,t=3,p=1$LHZG57rDMJ+sJvIkpI3Jqw$XXx4Ov08UZCFXAOoP+kZTmpI9MVfnJkZ5lP77JNgt/s" });
            builder.HasData(new Users { Id = 4, Email = "brandt.fabian@gmail.com", Password = "$argon2id$v=19$m=65536,t=3,p=1$LHZG57rDMJ+sJvIkpI3Jqw$XXx4Ov08UZCFXAOoP+kZTmpI9MVfnJkZ5lP77JNgt/s" });
        }
    }
}
