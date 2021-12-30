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
        
        [HttpGet("{slug}")]
        public IActionResult GetBySlug(string slug)
        {
            var weapon = _weaponsService.GetBySlug(slug);

            if (weapon == null) return NotFound();

            return Ok(weapon);
        }
    }
}