using MediatR;
using System;

namespace SecureLab.Application.Users.Commands
{
    public class UserResponse : INotification
    {
        public UserResponse(Guid id)
        {
            this.UserId = id;
        }
        public Guid UserId { get; }
    }
}
