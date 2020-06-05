using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureLab.Domain.Entities;

namespace SecureLab.Persistence.Configurations
{
    class ActionConfiguration : IEntityTypeConfiguration<Action>
    {
        public void Configure(EntityTypeBuilder<Action> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired().HasColumnName("ActionId");

            builder.Property(e => e.UserId).IsRequired();

            builder.Property(e => e.RoomId).IsRequired();

            builder.Property(e => e.ActionTimestamp).HasColumnType("date");

            builder.Property(e => e.ActionType).IsRequired().HasMaxLength(4);
        }
    }
}
