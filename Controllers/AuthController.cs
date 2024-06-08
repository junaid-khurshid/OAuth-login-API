using Microsoft.AspNetCore.Mvc;
using OAuth_login_API.Models;
using OAuth_login_API.Services;

namespace OAuth_login_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public AuthController()
        {

        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var user = UserRepository.Users.FirstOrDefault(u => u.Username == request.Username && u.Password == request.Password);

            if (user == null)
                return Unauthorized(new LoginResponse { Token = string.Empty, Message = "Invalid Credentials" });

            var token = TokenService.GenerateToken(user);

            return Ok(new LoginResponse { Token = token, Message = "Success" });
        }

    }
}
