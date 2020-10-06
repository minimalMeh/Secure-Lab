using MediatR;
using System.Linq;
using System.Threading;
using SecureLab.Persistence;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SecureLab.Application.RoomGroups.Queries;
using SecureLab.Models.DTOs;

namespace SecureLab.Application.Users.Commands.CreateUser
{
    public class GetRoomsInRoomGroupQueryHandler : IRequestHandler<GetRoomsInRoomGroupQuery, IEnumerable<RoomDto>>
    {
        private readonly SecureLabDbContext _context;

        public GetRoomsInRoomGroupQueryHandler(SecureLabDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<RoomDto>> Handle(GetRoomsInRoomGroupQuery request, CancellationToken cancellationToken)
        {
            var roomGroup = await this._context.RoomGroups
                            .Include(x => x.RoomToRoomGroups)
                            .ThenInclude(x => x.Room)
                            .FirstOrDefaultAsync(i => i.Id == request.RoomGroupId);
            var roomgroups = roomGroup.RoomToRoomGroups;
            return roomgroups.Select(r => new RoomDto { RoomId = r.Room.Id, Number = r.Room.Number, RoomType = r.Room.RoomType }).ToArray();
        }
    }
}
