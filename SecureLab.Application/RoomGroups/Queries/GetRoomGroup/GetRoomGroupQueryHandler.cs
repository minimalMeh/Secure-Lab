using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SecureLab.Application.RoomGroups.Queries;
using SecureLab.Domain.Entities;
using SecureLab.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SecureLab.Application.RoomGroups.Queries
{
    public class GetRoomGroupQueryHandler : IRequestHandler<GetRoomGroupQuery, RoomGroup>
    {
        private readonly SecureLabDbContext _context;

        public GetRoomGroupQueryHandler(SecureLabDbContext context)
        {
            this._context = context;
        }

        public async Task<RoomGroup> Handle(GetRoomGroupQuery request, CancellationToken cancellationToken)
        {
            return await this._context.RoomGroups.FirstOrDefaultAsync(i => i.Id == request.Id);
        }
    }
}
