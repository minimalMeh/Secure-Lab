using MediatR;
using SecureLab.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SecureLab.Application.Rooms.Queries.GetAll
{
    public class GetAllRoomsQuery : IRequest<IEnumerable<Room>>
    {
    }
}
