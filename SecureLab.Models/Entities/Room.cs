using System;
using SecureLab.Domain.Entities.ComplexEntities;
using System.Collections.Generic;

namespace SecureLab.Domain.Entities
{
    public class Room
    {
        public Room()
        {
            this.RoomToRoomGroups = new HashSet<RoomsToRoomGroups>();
        }

        public Guid Id { get; set; }

        public string Number { get; set; }

        public string RoomType { get; set; }

        public virtual ICollection<RoomsToRoomGroups> RoomToRoomGroups { get; set; }

    }
}
