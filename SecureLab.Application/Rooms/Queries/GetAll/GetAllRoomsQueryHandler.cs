using MediatR;
using Microsoft.EntityFrameworkCore;
using SecureLab.Domain.Entities;
using SecureLab.Persistence;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SecureLab.Application.Rooms.Queries.GetAll
{
    class GetAllRoomsQueryHandler : IRequestHandler<GetAllRoomsQuery, IEnumerable<Room>>
    {
        private readonly SecureLabDbContext _context;

        public GetAllRoomsQueryHandler(SecureLabDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Room>> Handle(GetAllRoomsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Rooms.ToArrayAsync();
        }
    }
}
