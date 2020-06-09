using MediatR;
using Microsoft.EntityFrameworkCore;
using SecureLab.Domain.Entities;
using SecureLab.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SecureLab.Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, UserResponse>
    {
        private readonly IMediator _mediator;
        private readonly SecureLabDbContext _context;
        public UpdateUserCommandHandler(IMediator mediator, SecureLabDbContext context)
        {
            this._mediator = mediator;
            this._context = context;
        }
        public async Task<UserResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            //TODO: add check if the person with email exists
            var user = await _context.Users.FirstOrDefaultAsync(e => e.Id == request.Id);
            if (user != null)
            {
                user.UserName = request.UserName;
                user.PhoneNumber = request.PhoneNumber;
                user.Information = request.Information;
                user.AllowedRoomGroups = request.AllowedRoomGroups.ToArray();
                user.AllowedRooms = request.AllowedRooms.ToArray();
            }

            _context.Users.Update(user);
            await _context.SaveChangesAsync(cancellationToken);

            //Still don't know how to work with it
            //https://mayuanyang.github.io/Mediator.Net/
            //await _mediator.Publish(new UserCreated { });

            return new UserResponse(user.Id);
        }
    }
}
