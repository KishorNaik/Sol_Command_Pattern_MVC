using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sol_Command.Cores.Dispatchers;
using Sol_Command_Api.Commands;
using Sol_Command_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Command_Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserDemoController : ControllerBase
    {
        private readonly ICommandDispatcher commandDispatcher = null;

        public UserDemoController(ICommandDispatcher commandDispatcher)
        {
            this.commandDispatcher = commandDispatcher;
        }

        [HttpPost("adduser")]
        public async Task<IActionResult> AddUserEndPoint([FromBody] UserModel userModel)
        {
            var response = await this.commandDispatcher.DispatchAsync<UserModel, bool>(typeof(AddUserCommand), userModel);
            return base.Ok(response);
        }
    }
}