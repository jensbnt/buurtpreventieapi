using BuurtPreventie.Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BuurtPreventie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GemeenteController : ControllerBase
    {
        private readonly IGemeenteRepository _gemeenteRepository;

        public GemeenteController(IGemeenteRepository gemeenteRepository)
        {
            _gemeenteRepository = gemeenteRepository;
        }

        // GET: api/Gemeente?filter=Has
        [HttpGet]
        public IActionResult GetAllFiltered([FromQuery] string filter = "")
        {
            var gemeentes = _gemeenteRepository.GetAllFiltered(filter);

            return Ok(gemeentes);
        }

        // GET: api/Gemeente/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var gemeente = _gemeenteRepository.GetById(id);

            return Ok(gemeente);
        }
    }
}
