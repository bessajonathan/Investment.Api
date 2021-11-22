using Investment.Core.Entities;
using Investment.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Investment.Infra.Configurations
{
    public class ActiveConfiguration : IEntityTypeConfiguration<Active>
    {
        public void Configure(EntityTypeBuilder<Active> builder)
        {
            builder.ToTable("Actives");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Amount).IsRequired();

            builder.Property(x => x.ActiveType)
                .HasConversion(new EnumToStringConverter<EUserActiveType>());
        }
    }
}
