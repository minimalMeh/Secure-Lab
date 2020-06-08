using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SecureLab.Application.Users.Commands.CreateUser
{
    public class UserResponse : INotification
    {
        public UserResponse(Guid id)
        {
            this.UserId = id;
        }
        public Guid UserId { get; }

        //TODO: Figure out what is it
        //IDK WHAT IS IT FOR NOW. I WILL KNOW
        //public class UserCreatedHandler : INotificationHandler<UserCreated>
        //{
        //    private readonly INotificationService _notification;
        //    public Task Handle(UserCreated notification, CancellationToken cancellationToken)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}
