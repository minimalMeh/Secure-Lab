using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureLab.Domain.Entities;
using SecureLab.Persistence.Converters;

namespace SecureLab.Persistence.Configurations
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired().HasColumnName("UserId");

            builder.Property(e => e.UserName).IsRequired().HasMaxLength(120);

            builder.Property(e => e.Email).IsRequired().HasMaxLength(30);

            builder.Property(e => e.Information).HasMaxLength(256);

            builder.Property(e => e.AllowedRoomGroups).HasConversion(Converter.StringParseConverter);

            builder.Property(e => e.AllowedRooms).HasConversion(Converter.StringParseConverter);

            builder.HasIndex(e => e.Email).IsUnique();
        }
    }
}
