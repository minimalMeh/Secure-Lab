using System;
using MediatR;
using SecureLab.Persistence;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecureLab.Domain.Entities;
using System.Collections.Generic;
using SecureLab.Application.RoomGroups.Queries;

namespace SecureLab.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomGroupController
    {
        private readonly SecureLabDbContext _context;
        private readonly IMediator _mediator;

        public RoomGroupController(SecureLabDbContext context, IMediator mediator)
        {
            this._context = context;
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<RoomGroup>> GetRoomGroups()
        {
            return (IEnumerable<RoomGroup>)await _mediator.Send(new GetAllRoomGroupsQuery());
        }

        [HttpGet("{id}")]
        public async Task<RoomGroup> GetRoomGroup([FromRoute] Guid id)
        {
            return await _mediator.Send(new GetRoomGroupQuery { Id = id });
        }

        [HttpGet("rooms/{id}")]
        public async Task<IEnumerable<RoomDTO>> GetRoomsInRoomGroup([FromRoute] Guid id)
        {
            return await _mediator.Send(new GetRoomsInRoomGroupQuery { RoomGroupId = id });
        }
    }
}
