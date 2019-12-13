using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SecureLab.Domain.Entities
{
    public class User : IdentityUser
    {
        User() : base()
        {
            this.UserRoles = new HashSet<UserRole>();
        }

        public string Information { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
