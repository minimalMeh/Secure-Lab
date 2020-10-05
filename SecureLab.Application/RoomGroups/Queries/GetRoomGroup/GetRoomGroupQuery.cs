using MediatR;
using SecureLab.Domain.Entities;
using System;

namespace SecureLab.Application.RoomGroups.Queries
{
    public class GetRoomGroupQuery : IRequest<RoomGroup>
    {
        public Guid Id { get; set; }
    }
}
