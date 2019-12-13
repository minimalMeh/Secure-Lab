using System;
using System.Collections.Generic;

namespace SecureLab.Domain.Entities
{
    public class Group
    {
        public Group()
        {
            this.RoomGroups = new HashSet<RoomGroup>();
        }
        public Guid Id { get; set; }

        public ICollection<RoomGroup> RoomGroups { get; set; }

        public string[] AllowedRolesId { get; set; }
    }
}
