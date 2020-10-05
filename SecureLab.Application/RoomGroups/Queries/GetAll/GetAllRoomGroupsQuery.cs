using MediatR;
using SecureLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecureLab.Application.RoomGroups.Queries
{
    public class GetAllRoomGroupsQuery : IRequest<IEnumerable<RoomGroup>>
    {

    }
}
