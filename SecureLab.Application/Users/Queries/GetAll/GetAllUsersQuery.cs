using MediatR;
using SecureLab.Models.DTOs;
using System.Collections.Generic;

namespace SecureLab.Application.Users.Queries.GetAll
{
    public class GetAllUsersQuery : IRequest<IEnumerable<UserDto>>
    {
    }
}
