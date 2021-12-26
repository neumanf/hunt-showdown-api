using Microsoft.AspNetCore.Mvc;

namespace HuntShowdownAPI.Controllers
{
    [Route("api/weapons")]
    [ApiController]
    public class WeaponsController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult GetAll()
        {
            Message message = new("Weapons endpoint");
            return Ok(message);
        }
    }

    public record Message(string Text);
}