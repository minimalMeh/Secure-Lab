using System;
using SecureLab.Domain.Entities.ComplexEntities;
using System.Collections.Generic;

namespace SecureLab.Domain.Entities
{
    public class UserGroup
    {
        public UserGroup()
        {
            this.UsersToUserGroups = new HashSet<UsersToUserGroups>();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<UsersToUserGroups> UsersToUserGroups { get; set; }
    }
}
