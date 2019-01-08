using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchEF.Domain.Entities;

namespace SwitchEF.Infra.Data.Config
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Name).IsRequired().HasMaxLength(100);
            builder.Property(g => g.Description).IsRequired().HasMaxLength(100);
            builder.Property(g => g.PhotoUrl).IsRequired().HasMaxLength(1000);
            builder.HasMany(g => g.Postings).WithOne(p => p.Group);
        }
    }
}
