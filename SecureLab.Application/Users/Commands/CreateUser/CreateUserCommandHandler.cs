using MediatR;
using Microsoft.AspNetCore.Identity;
using SecureLab.Domain.Entities;
using SecureLab.Persistence;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SecureLab.Application.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserResponse>
    {
        private readonly IMediator _mediator;
        private readonly UserManager<User> _userManager;
        private readonly SecureLabDbContext _context;

        public CreateUserCommandHandler(IMediator mediator, UserManager<User> userManager, SecureLabDbContext context)
        {
            this._mediator = mediator;
            this._context = context;
            this._userManager = userManager;
        }

        public async Task<UserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var entity = new User
            {
                Id = Guid.NewGuid(),
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                Information = request.Information
            };

            await _userManager.CreateAsync(entity);

            _context.Users.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return new UserResponse(entity.Id);
        }
    }
}
