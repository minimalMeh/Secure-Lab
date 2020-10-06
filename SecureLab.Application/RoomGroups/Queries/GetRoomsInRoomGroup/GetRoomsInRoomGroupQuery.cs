using MediatR;
using SecureLab.Models.DTOs;
using System;
using System.Collections.Generic;

namespace SecureLab.Application.RoomGroups.Queries
{
    public class GetRoomsInRoomGroupQuery : IRequest<IEnumerable<RoomDto>>
    {
        public Guid RoomGroupId { get; set; }
    }
}
