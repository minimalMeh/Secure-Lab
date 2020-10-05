using System;
using SecureLab.Domain.Entities.ComplexEntities;
using System.Collections.Generic;

namespace SecureLab.Domain.Entities
{
    public class RoomGroup
    {
        public RoomGroup()
        {
            this.RoomToRoomGroups = new HashSet<RoomsToRoomGroups>();
        }
        
        public Guid Id { get; set; }
        
        public string Title { get; set; }
        
        public virtual ICollection<RoomsToRoomGroups> RoomToRoomGroups { get; set; }
    }
}
