using BuurtPreventie.Data.Repositories.Interfaces;
using BuurtPreventie.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuurtPreventie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZoneController : ControllerBase
    {
        private readonly IZoneRepository _zoneRepository;

        public ZoneController(IZoneRepository zoneRepository)
        {
            _zoneRepository = zoneRepository;
        }

        // GET: api/Zone/gemeente/5
        [HttpGet("gemeente/{gemeenteId}")]
        public IActionResult GetAllByGemeenteId(int gemeenteId)
        {
            var zones = _zoneRepository.GetAllByGemeenteId(gemeenteId);

            return Ok(zones);
        }

        // GET: api/Zone/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var zone = _zoneRepository.GetById(id);

            return Ok(zone);
        }

        // POST: api/Zone
        [HttpPost]
        public IActionResult Post([FromBody] CreateZoneModel model)
        {
            var zone = model.ToZone();

            var id = _zoneRepository.Add(zone);

            return Ok(id);
        }
    }
}