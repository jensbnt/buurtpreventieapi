using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuurtPreventie.Data.Repositories.Interfaces;
using BuurtPreventie.Domain;
using Microsoft.AspNetCore.Http;
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

        // POST: api/Opmerking/zone/5
        [HttpPost("zone/{zoneId}")]
        public IActionResult Post(int zoneId, [FromBody] Opmerking opmerking)
        {
            opmerking.ZoneId = zoneId;
            _opmerkingRepository.Add(opmerking);

            return Ok();
        }
    }
}