using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecureLab.Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest<UserResponse>
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Information { get; set; }
        public IEnumerable<string> AllowedRoomGroups { get; set; }
        public IEnumerable<string> AllowedRooms { get; set; }
    }
}
