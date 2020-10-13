using System;
using System.Collections.Generic;
using System.Text;

namespace SecureLab.Application.UserGroups
{
    public class UserGroupResponse
    {
        public UserGroupResponse(Guid id, string title)
        {
            this.Id = id;
            this.Title = title;
        }

        public Guid Id { get; }

        public string Title { get; }
    }
}
