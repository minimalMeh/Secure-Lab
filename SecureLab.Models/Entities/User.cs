using Microsoft.AspNetCore.Identity;
using SecureLab.Domain.Entities.ComplexEntities;
using System;
using System.Collections.Generic;

namespace SecureLab.Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        public User() : base()
        {
            this.UsersToUserGroups = new HashSet<UsersToUserGroups>();
        }

        public string Information { get; set; }

        public ICollection<UsersToUserGroups> UsersToUserGroups { get; set; }

        //firstly it searches whether room in one of the allowed groups
        public string[] AllowedRoomGroups { get; set; }

        //then it searches whether this room certainly allowed
        public string[] AllowedRooms { get; set; }
    }
}
