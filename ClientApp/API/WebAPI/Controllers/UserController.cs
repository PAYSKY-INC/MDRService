using MDRService.Application.Users.Commands.CreateUser;
using MDRService.Application.Users.Commands.Login;
using MDRService.WebAPI.Common;
using Microsoft.AspNetCore.Mvc;

namespace MDRService.WebAPI.Controllers
{
    public class UserController : BaseApiController
    {
        #region Actions
        [HttpPost("user-login")]
        public async Task<IActionResult> UserLogin([FromBody] LoginCommand loginCommand)
        {
            return Result(await Mediator.Send(loginCommand));
        }

        [HttpPost("Create-user")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand loginCommand)
        {
            return Result(await Mediator.Send(loginCommand));
        }
        #endregion
    }
}
