using HuntShowdownAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HuntShowdownAPI.Controllers
{
    [Route("api/weapons")]
    [ApiController]
    public class WeaponsController : ControllerBase
    {
        private readonly WeaponsService _weaponsService;

        public WeaponsController(WeaponsService weaponsService)
        {
            _weaponsService = weaponsService;
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            var weapons = _weaponsService.GetAll();
            return Ok(weapons);
        }
    }
}