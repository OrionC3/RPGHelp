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
        }
    }
}
