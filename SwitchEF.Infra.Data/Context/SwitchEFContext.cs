using Microsoft.EntityFrameworkCore;
using SwitchEF.Domain.Entities;
using SwitchEF.Infra.Data.Config;

namespace SwitchEF.Infra.Data.Context
{
    public class SwitchEFContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public SwitchEFContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
