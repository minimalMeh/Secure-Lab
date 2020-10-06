using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SecureLab.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

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
            var user = await _context.Users.FirstOrDefaultAsync(e => e.Id == request.Id);
            if (user != null)
            {
                user.UserName = this.UpdateField(user.UserName, request.UserName);
                user.PhoneNumber = this.UpdateField(user.PhoneNumber, request.PhoneNumber);
                user.Information = this.UpdateField(user.Information, request.Information);
                user.AllowedRoomGroups = this.UpdateField(user.AllowedRoomGroups, request.AllowedRoomGroups?.ToArray());
                user.AllowedRooms = this.UpdateField(user.AllowedRooms, request.AllowedRooms?.ToArray());
            }

            _context.Users.Update(user);
            await _context.SaveChangesAsync(cancellationToken);

            return new UserResponse(user.Id);
        }

        /// <summary>
        /// Check wheter field changed from previous value.
        /// </summary>
        /// <returns>Returns updated value or previous value.</returns>
        private T UpdateField<T> (T oldValue, T newValue)
        {
            if (newValue != null && !EqualityComparer<T>.Default.Equals(oldValue, newValue))
            {
                return newValue;
            }
            return oldValue;
        }
    }
}
