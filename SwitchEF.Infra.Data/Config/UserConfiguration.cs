using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchEF.Domain.Entities;

namespace SwitchEF.Infra.Data.Config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).HasMaxLength(400).IsRequired();
            builder.Property(u => u.Lastname).HasMaxLength(400).IsRequired();
            builder.Property(u => u.Birthdate).IsRequired();
            builder.Property(u => u.Password).HasMaxLength(400).IsRequired();
            builder.Property(u => u.Gender).IsRequired();            
            builder.Property(u => u.PhotoUrl).HasMaxLength(400).IsRequired();
            
        }
    }
}
