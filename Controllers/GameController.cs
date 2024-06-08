using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OAuth_login_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        public GameController() { }

        [HttpGet("b_game")]
        [Authorize(Roles = "player,admin")]
        public IActionResult GetDefaultBoardGame()
        {
            return Ok("Welcome to the Board Game!");
        }

        [HttpGet("vip_character_personalize")]
        [Authorize(Roles = "admin")]
        public IActionResult GetVIPBoardGame()
        {
            return Ok("Welcome to VIP Board Game!");
        }
    }
}
