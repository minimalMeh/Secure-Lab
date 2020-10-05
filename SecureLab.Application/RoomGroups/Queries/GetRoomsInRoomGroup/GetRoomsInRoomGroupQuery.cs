using MediatR;
using System;
using System.Collections.Generic;

namespace SecureLab.Application.RoomGroups.Queries
{
    public class GetRoomsInRoomGroupQuery : IRequest<IEnumerable<RoomDTO>>
    {
        public Guid RoomGroupId { get; set; }
    }
}
