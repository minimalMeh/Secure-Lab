using MediatR;
using SecureLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecureLab.Application.RoomGroups.Queries
{
    public class GetRoomsInRoomGroupQuery : IRequest<IEnumerable<RoomDTO>>
    {
        public Guid RoomGroupId { get; set; }
    }
}
