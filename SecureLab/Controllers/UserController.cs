using MediatR;
using Microsoft.AspNetCore.Mvc;
using SecureLab.Persistence;
using System;
using System.Threading.Tasks;
using SecureLab.Application.Users.Commands.CreateUser;

namespace SecureLab.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly SecureLabDbContext _context;
        private readonly IMediator _mediator;

        public UserController(SecureLabDbContext context, IMediator mediator)
        {
            this._context = context;
            this._mediator = mediator;
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction("Create User", new { Id = result.UserId }, result);
        }
    }
}
