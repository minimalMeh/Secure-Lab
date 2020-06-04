using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureLab.Domain.Entities;
using System;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SecureLab.Persistence.Configurations
{
    class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired().HasColumnName("RoomId");

            builder.Property(e => e.RoomType).IsRequired().HasMaxLength(18);

            builder.Property(e => e.Number).IsRequired().HasMaxLength(10);
        }
    }
}
