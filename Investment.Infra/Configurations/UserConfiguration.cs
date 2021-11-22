using Investment.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Investment.Infra.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.FirebaseId).IsRequired(true).HasMaxLength(400);
            builder.Property(x => x.CreatedAt).IsRequired(true);
            builder.Property(x => x.UpdatedAt).IsRequired(false);
        }
    }
}
