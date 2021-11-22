using Investment.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Investment.Infra.Configurations
{
    public class WalletConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.ToTable("Wallets");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Amount).IsRequired(true);

            builder.HasOne(x => x.User).WithOne(y => y.Wallet)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
