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

            builder.Property(e => e.RoomType).IsRequired().HasColumnType("varchar(50)").IsUnicode(false);

            builder.Property(e => e.Number).IsRequired().HasColumnType("varchar(50)");
        }
    }
}
