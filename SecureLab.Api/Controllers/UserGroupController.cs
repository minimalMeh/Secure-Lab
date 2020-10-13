using MediatR;
using Microsoft.AspNetCore.Mvc;
using SecureLab.Application.UserGroups.Commands.CreateUserGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecureLab.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserGroupController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserGroupController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserGroup([FromBody] CreateUserGroupCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction("Create User", new { Id = result.Id }, result);
        }
    }
}
