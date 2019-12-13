using System;
using System.Collections.Generic;

namespace SecureLab.Domain.Entities
{
    public class Room
    {
        public Room()
        {
            this.RoomGroups = new HashSet<RoomGroup>();
        }
        public Guid Id { get; set; }

        public string Number { get; set; }

        public string RoomType { get; set; }

        public ICollection<RoomGroup> RoomGroups { get; set; }

        public string[] AllowedRolesId { get; set; }
    }
}
