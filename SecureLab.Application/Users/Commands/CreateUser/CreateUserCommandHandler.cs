using MediatR;
using SecureLab.Domain.Entities;
using SecureLab.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SecureLab.Application.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserResponse>
    {
        private readonly IMediator _mediator;
        private readonly SecureLabDbContext _context;
        public CreateUserCommandHandler(IMediator mediator, SecureLabDbContext context)
        {
            this._mediator = mediator;
            this._context = context;
        }
        public async Task<UserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            //TODO: add check if the person with email exists
            
            var entity = new User
            {
                Id = Guid.NewGuid(),
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                Information = request.Information 
            };

            _context.Users.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            //Still don't know how to work with it
            //https://mayuanyang.github.io/Mediator.Net/
            //await _mediator.Publish(new UserCreated { });

            return new UserResponse(entity.Id); 
        }
    }
}
