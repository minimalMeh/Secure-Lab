using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecureLab.Application.UserGroups.Commands.CreateUserGroup
{
    public class CreateUserGroupCommand : IRequest<UserGroupResponse>
    {
        public string Name { get; set; }
    }
}
