using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace SecureLab.Domain.Entities
{
    public class Role : IdentityRole
    {
        public Role() : base()
        {
            this.UserRoles = new HashSet<UserRole>();
        }

        public Role(string roleName): base(roleName)
        {
            this.UserRoles = new HashSet<UserRole>();
        }

        public Role(string roleName, string description) : base(roleName)
        {
            this.UserRoles = new HashSet<UserRole>();
            this.Description = description;
        }

        public string Description { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
