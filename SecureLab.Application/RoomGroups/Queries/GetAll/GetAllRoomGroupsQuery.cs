using MediatR;
using SecureLab.Domain.Entities;
using System.Collections.Generic;

namespace SecureLab.Application.RoomGroups.Queries
{
    public class GetAllRoomGroupsQuery : IRequest<IEnumerable<RoomGroup>>
    {
    }
}
