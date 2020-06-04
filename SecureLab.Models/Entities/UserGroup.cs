using System;
using System.Collections.Generic;
using System.Text;

namespace SecureLab.Domain.Entities
{
    public class UserGroup
    {
        public UserGroup()
        {
            this.Users = new HashSet<User>();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
