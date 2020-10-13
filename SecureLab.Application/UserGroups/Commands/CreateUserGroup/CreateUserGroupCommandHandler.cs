using MediatR;
using SecureLab.Domain.Entities;
using SecureLab.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SecureLab.Application.UserGroups.Commands.CreateUserGroup
{
    class CreateUserGroupCommandHandler : IRequestHandler<CreateUserGroupCommand, UserGroupResponse>
    {
        private readonly IMediator _mediator;
        private readonly SecureLabDbContext _context;

        public CreateUserGroupCommandHandler(IMediator mediator, SecureLabDbContext context)
        {
            this._mediator = mediator;
            this._context = context;
        }

        public async Task<UserGroupResponse> Handle(CreateUserGroupCommand request, CancellationToken cancellationToken)
        {
            var entity = new UserGroup
            {
                Id = Guid.NewGuid(),
                Title = request.Name
            };

            _context.UserGroups.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return new UserGroupResponse(entity.Id, entity.Title);
        }
    }
}
