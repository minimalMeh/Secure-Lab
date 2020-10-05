using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureLab.Domain.Entities;

namespace SecureLab.Persistence.Configurations
{
    class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).IsRequired().HasColumnName("RoomId");

            builder.Property(e => e.RoomType).IsRequired().HasColumnType("nvarchar(50)").IsUnicode(true);

            builder.Property(e => e.Number).IsRequired().HasColumnType("nvarchar(50)").IsUnicode(true);
        }
    }
}
