using HuntShowdownAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace HuntShowdownAPI.Controllers
{
    [Route("api/weapons")]
    [ApiController]
    public class WeaponsController : ControllerBase
    {
        private readonly IWeaponsService _weaponsService;

        public WeaponsController(IWeaponsService weaponsService)
        {
            _weaponsService = weaponsService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll(string? search = null)
        {
            var weapons = await _weaponsService.GetAll(search);
            
            return Ok(weapons);
        }
        
        [HttpGet("{slug}")]
        public async Task<IActionResult> GetBySlug(string slug)
        {
            var weapon = await _weaponsService.GetBySlug(slug);

            if (weapon == null) return NotFound();

            return Ok(weapon);
        }
    }
}