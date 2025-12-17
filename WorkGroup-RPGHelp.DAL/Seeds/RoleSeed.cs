using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.DAL.Configs
{
    public class RoleSeed : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "User" }
            );

            builder.HasMany(r => r.User)
                   .WithMany(u => u.Role).UsingEntity(j => j.HasData(
                       new { UserId = 1, RoleId = 1 },
                       new { UserId = 1, RoleId = 2 },
                       new { UserId = 2, RoleId = 2 },
                       new { UserId = 3, RoleId = 2 },
                       new { UserId = 4, RoleId = 1 },
                       new { UserId = 4, RoleId = 2 }
                       ));
        }
    }
}
