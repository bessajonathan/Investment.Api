using Investment.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Investment.Infra.Configurations
{
    public class UserActiveConfiguration : IEntityTypeConfiguration<UserActive>
    {
        public void Configure(EntityTypeBuilder<UserActive> builder)
        {
            builder.ToTable("UserActives");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.User).WithMany(y => y.Actives)
               .HasForeignKey(x => x.UserId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Active).WithMany()
               .HasForeignKey(x => x.Active)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
