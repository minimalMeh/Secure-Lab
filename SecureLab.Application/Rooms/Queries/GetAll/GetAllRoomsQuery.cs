using MediatR;
using SecureLab.Domain.Entities;
using System.Collections.Generic;

namespace SecureLab.Application.Rooms.Queries.GetAll
{
    public class GetAllRoomsQuery : IRequest<IEnumerable<Room>>
    {
    }
}
