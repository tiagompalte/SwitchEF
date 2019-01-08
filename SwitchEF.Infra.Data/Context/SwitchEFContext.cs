using Microsoft.EntityFrameworkCore;
using SwitchEF.Domain.Entities;
using SwitchEF.Infra.Data.Config;

namespace SwitchEF.Infra.Data.Context
{
    public class SwitchEFContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Posting> Postings { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Identification> Identifications { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<EducationalInstitution> EducationalInstitutions { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Workplace> Workplaces { get; set; }

        public SwitchEFContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PostingConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new UserGroupConfiguration());
            modelBuilder.ApplyConfiguration(new FriendConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
