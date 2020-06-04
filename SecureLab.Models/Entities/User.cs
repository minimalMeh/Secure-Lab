using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SecureLab.Domain.Entities
{
    public class User : IdentityUser
    {
        public User() : base()
        {
            this.UserGroups = new HashSet<UserGroup>();
        }

        public string Information { get; set; }

        public ICollection<UserGroup> UserGroups { get; set; }

        //firstly it searches whether room in one of the allowed groups
        public string[] AllowedRoomGroups { get; set; }

        //then it searches whether this room certainly allowed
        public string[] AllowedRooms { get; set; }
    }
}
