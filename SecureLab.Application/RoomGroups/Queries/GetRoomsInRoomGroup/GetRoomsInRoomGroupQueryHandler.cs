using MediatR;
using Microsoft.EntityFrameworkCore;
using SecureLab.Application.RoomGroups.Queries;
using SecureLab.Domain.Entities;
using SecureLab.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SecureLab.Application.Users.Commands.CreateUser
{
    public class GetRoomsInRoomGroupQueryHandler : IRequestHandler<GetRoomsInRoomGroupQuery, IEnumerable<RoomDTO>>
    {
        private readonly SecureLabDbContext _context;

        public GetRoomsInRoomGroupQueryHandler(SecureLabDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<RoomDTO>> Handle(GetRoomsInRoomGroupQuery request, CancellationToken cancellationToken)
        {
            // EF Core won't load related properties automatically, so you'll need to explicitly do this

            var roomGroup = await this._context.RoomGroups
                            .Include(x => x.RoomToRoomGroups)
                            .ThenInclude(x => x.Room)
                            .FirstOrDefaultAsync(i => i.Id == request.RoomGroupId);
            var roomgroups = roomGroup.RoomToRoomGroups;
            return roomgroups.Select(r => new RoomDTO { RoomId = r.Room.Id, Number = r.Room.Number, RoomType = r.Room.RoomType }).ToArray();
        }
    }
}
