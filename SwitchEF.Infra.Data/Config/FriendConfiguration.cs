using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchEF.Domain.Entities;

namespace SwitchEF.Infra.Data.Config
{
    public class FriendConfiguration : IEntityTypeConfiguration<Friend>
    {
        public void Configure(EntityTypeBuilder<Friend> builder)
        {
            builder.HasKey(f => new { f.UserId, f.UserFriendId });            
        }
    }
}
