using BuurtPreventie.Data.Repositories.Interfaces;
using BuurtPreventie.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuurtPreventie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpmerkingController : ControllerBase
    {
        private readonly IOpmerkingRepository _opmerkingRepository;

        public OpmerkingController(IOpmerkingRepository opmerkingRepository)
        {
            _opmerkingRepository = opmerkingRepository;
        }

        // GET: api/Opmerking/zone/5
        [HttpGet("zone/{zoneId}")]
        public IActionResult GetAllByGemeenteId(int zoneId)
        {
            var opmerkingen = _opmerkingRepository.GetAllByZoneId(zoneId);

            return Ok(opmerkingen);
        }

        // POST: api/Opmerking
        [HttpPost]
        public IActionResult Post([FromBody] CreateOpmerkingModel model)
        {
            var opmerking = model.ToOpmerking();

            var id = _opmerkingRepository.Add(opmerking);

            return Ok(id);
        }
    }
}