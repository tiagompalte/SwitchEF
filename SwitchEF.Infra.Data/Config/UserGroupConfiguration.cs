using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchEF.Domain.Entities;

namespace SwitchEF.Infra.Data.Config
{
    public class UserGroupConfiguration : IEntityTypeConfiguration<UserGroup>
    {
        public void Configure(EntityTypeBuilder<UserGroup> builder)
        {
            builder.HasKey(u => new { u.UserId, u.GroupId });
            builder.Property(u => u.DateCreated).IsRequired();
            builder.Property(u => u.Admin).IsRequired();
        }
    }
}
