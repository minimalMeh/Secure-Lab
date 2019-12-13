using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureLab.Domain.Entities;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Collections.Generic;
using System.Text;

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

            builder.Property(e => e.Duration).HasColumnType("time(7)");

            builder.Property(e => e.ActionStart).HasColumnType("date");

            builder.Property(e => e.ActionEnd).HasColumnType("date");

            builder.Property(e => e.ActionType).IsRequired().HasMaxLength(4);
        }
    }
}
