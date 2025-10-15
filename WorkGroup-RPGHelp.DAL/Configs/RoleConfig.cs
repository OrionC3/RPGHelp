using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.DAL.Configs
{
    public class RoleConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles").HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();

            builder.HasIndex(r => r.Name).IsUnique();
            builder.Property(r => r.Name).IsRequired().HasMaxLength(50);

            builder.HasData(
                new Role { Id = 1, Name = "Admin" },
                new Role { Id = 2, Name = "GM" },
                new Role { Id = 3, Name = "Players" }
            );

            builder.HasMany(r => r.User)
                   .WithMany(u => u.Role).UsingEntity(j => j.HasData(
                       new {UserId = 1, RoleId = 1},
                       new {UserId = 1, RoleId = 2},
                       new { UserId = 2, RoleId = 3 }
                       ));
        }
    }
}
