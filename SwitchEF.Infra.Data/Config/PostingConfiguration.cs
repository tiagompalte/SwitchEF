using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwitchEF.Domain.Entities;

namespace SwitchEF.Infra.Data.Config
{
    public class PostingConfiguration : IEntityTypeConfiguration<Posting>
    {
        public void Configure(EntityTypeBuilder<Posting> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Date).IsRequired();
            builder.Property(p => p.Text).IsRequired().HasMaxLength(400);
            builder.HasOne(p => p.User).WithMany(u => u.Postings);
        }
    }
}
