using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using SecureLab.Persistence;
using Microsoft.EntityFrameworkCore;

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
                user.UserName = request.UserName;
                user.PhoneNumber = request.PhoneNumber;
                user.Information = request.Information;
                user.AllowedRoomGroups = request.AllowedRoomGroups.ToArray();
                user.AllowedRooms = request.AllowedRooms.ToArray();
            }

            _context.Users.Update(user);
            await _context.SaveChangesAsync(cancellationToken);

            return new UserResponse(user.Id);
        }
    }
}
