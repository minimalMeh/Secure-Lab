using MediatR;
using SecureLab.Persistence;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecureLab.Application.Users.Commands.CreateUser;
using SecureLab.Application.Users.Commands.UpdateUser;

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

        [HttpPut("")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction("Update User", new { Id = result.UserId }, result);
        }
    }
}
