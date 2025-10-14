using Microsoft.EntityFrameworkCore;
using WorkGroup_RPGHelp.DL.Entities;

namespace WorkGroup_RPGHelp.DAL.Contexts
{
    public class RPGHelpContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Campagn> Campagns { get; set; }

        public RPGHelpContext(DbContextOptions<RPGHelpContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RPGHelpContext).Assembly);

        }
    }
}
