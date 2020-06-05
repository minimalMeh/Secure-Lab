using System;

namespace SecureLab.Domain.Entities.ComplexEntities
{
    public class UsersToUserGroups
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid UserGroupId { get; set; }
        public UserGroup UserGroup { get; set; }
    }
}
