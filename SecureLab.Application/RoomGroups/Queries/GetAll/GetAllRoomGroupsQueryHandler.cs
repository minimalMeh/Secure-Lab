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

namespace SecureLab.Application.Users.Commands.CreateUser
{
    public class GetAllRoomGroupsQueryHandler : IRequestHandler<GetAllRoomGroupsQuery, IEnumerable<RoomGroup>>
    {
        private readonly SecureLabDbContext _context;

        public GetAllRoomGroupsQueryHandler(SecureLabDbContext context)
        {
            this._context = context;
        }

        async Task<IEnumerable<RoomGroup>> IRequestHandler<GetAllRoomGroupsQuery, IEnumerable<RoomGroup>>.Handle(GetAllRoomGroupsQuery request, CancellationToken cancellationToken)
        {
            return await _context.RoomGroups.ToArrayAsync();
        }
    }
}
