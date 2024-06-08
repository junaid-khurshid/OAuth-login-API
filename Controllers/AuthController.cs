using Microsoft.AspNetCore.Mvc;
using OAuth_login_API.Models;

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

            return Ok();
        }

    }
}
