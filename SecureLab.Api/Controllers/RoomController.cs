using MediatR;
using Microsoft.AspNetCore.Mvc;
using SecureLab.Application.Rooms.Queries.GetAll;
using SecureLab.Domain.Entities;
using SecureLab.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecureLab.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomController : ControllerBase
    {
        private readonly SecureLabDbContext _context;
        private readonly IMediator _mediator;

        public RoomController(SecureLabDbContext context, IMediator mediator)
        {
            this._context = context;
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Room>> GetRooms()
        {
            return await _mediator.Send(new GetAllRoomsQuery());
        }
    }
}
