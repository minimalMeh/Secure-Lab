using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecureLab.Application.Users.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<UserResponse>
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Information { get; set; }
    }
}
