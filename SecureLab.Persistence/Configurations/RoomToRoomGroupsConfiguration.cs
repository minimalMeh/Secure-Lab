using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SecureLab.Domain.Entities.ComplexEntities;

namespace SecureLab.Persistence.Configurations
{
    public class RoomsToRoomGroupsConfiguration : IEntityTypeConfiguration<RoomsToRoomGroups>
    {
        public void Configure(EntityTypeBuilder<RoomsToRoomGroups> builder)
        {
            builder.HasKey(e => new { e.RoomId, e.RoomGroupId });

            builder.HasOne(e => e.Room)
                .WithMany(g => g.RoomToRoomGroups)
                .HasForeignKey(k => k.RoomId);

            builder.HasOne(e => e.RoomGroup)
               .WithMany(g => g.RoomToRoomGroups)
               .HasForeignKey(k => k.RoomGroupId);
        }
    }
}
