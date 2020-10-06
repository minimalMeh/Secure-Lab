using MediatR;
using SecureLab.Models.DTOs;
using SecureLab.Persistence;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SecureLab.Application.Users.Queries.GetAll
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<UserDto>>
    {
        private readonly SecureLabDbContext _context;
        private readonly TaskCompletionSource<IEnumerable<UserDto>> tsc = new TaskCompletionSource<IEnumerable<UserDto>>();

        public GetAllUsersQueryHandler(SecureLabDbContext context)
        {
            this._context = context;
        }

        public Task<IEnumerable<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = this._context.Users.Select(u => new UserDto {Id = u.Id, UserName = u.UserName, Email = u.Email, PhoneNumber = u.PhoneNumber, Information = u.Information });
            tsc.SetResult(users);
            return tsc.Task;
        }
    }
}
