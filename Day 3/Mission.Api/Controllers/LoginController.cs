using Microsoft.AspNetCore.Mvc;
using Mission.Entities.ViewModels.Login;
using Mission.Services.IService;

namespace Mission.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("LoginUser")]
        public IActionResult LoginUser([FromBody] UserLoginRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid login request.");
            }

            try
            {
                var user = _userService.Login(model);

                if (user == null)
                {
                    return Unauthorized("Invalid credentials.");
                }

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}   