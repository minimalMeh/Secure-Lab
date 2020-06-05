using System;

namespace SecureLab.Domain.Entities.ComplexEntities
{
    public class RoomsToRoomGroups
    {
        public Guid RoomId { get; set; }
        public Room Room { get; set; }
        public Guid RoomGroupId { get; set; }
        public RoomGroup RoomGroup { get; set; }
    }
}
