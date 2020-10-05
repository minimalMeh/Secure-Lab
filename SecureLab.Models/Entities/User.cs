using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using SecureLab.Domain.Entities.ComplexEntities;

namespace SecureLab.Domain.Entities
{
    public class User : IdentityUser<Guid>
    {
        public User() : base()
        {
            this.UsersToUserGroups = new HashSet<UsersToUserGroups>();
        }

        public string Information { get; set; }

        public virtual ICollection<UsersToUserGroups> UsersToUserGroups { get; set; }

        public string[] AllowedRoomGroups { get; set; }

        public string[] AllowedRooms { get; set; }
    }
}
