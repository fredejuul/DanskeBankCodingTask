using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using DanskeBankCodingTask.Models;
using DanskeBankCodingTask.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DanskeBankCodingTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipalTaxController : ControllerBase
    {
        private readonly IDataRepository<MunicipalityTax> _dataRepository;
        ILogger log;
        public MunicipalTaxController(IDataRepository<MunicipalityTax> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/MunicipalTax
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<MunicipalityTax> municipalityTaxes = _dataRepository.GetAll();
            if (municipalityTaxes == null)
            {
                log.LogInformation("Unsuccessful query - no records found");
                return NotFound("No records were found");
            }
            return Ok(municipalityTaxes);
        }
        // GET: api/MunicipalTax/byId?id=2
        [HttpGet("byId", Name = "Get")]
        public IActionResult Get(int id)
        {
            MunicipalityTax municipalityTax = _dataRepository.Get(id);
            if (municipalityTax == null)
            {
                log.LogInformation("Unsuccessful query - no records found with requested ID");
                return NotFound("The tax record couldn't be found.");
            }

            return Ok(municipalityTax);
        }
        // GET: api/MunicipalTax/byMunicipality?municipality=Copenhagen&dateTime=2016-12-25T00:00:00
        [HttpGet("byMunicipality", Name = "GetMunicipality")]
        public IActionResult Get(string municipality, DateTime? dateTime)
        {
            if ((municipality == null) || (!dateTime.HasValue))
            {
                log.LogInformation("Unsuccessful query because of missing input parameters");
                return BadRequest("One or more input parameters format is missing");
            }
                
            IEnumerable<MunicipalityTax> municipalityTaxes = _dataRepository.GetAll();
            return Ok(municipalityTaxes.Where(e => e.Municipality == municipality && e.StartDate <= dateTime && e.EndDate >= dateTime));
        }
        // POST: api/MunicipalityTax
        [HttpPost]
        public IActionResult Post([FromBody] MunicipalityTax municipalityTax)
        {
            if (municipalityTax == null)
            {
                log.LogInformation("Unsuccessful POST because of missing input parameters");
                return BadRequest("Tax record is not complete.");
            }
            _dataRepository.Add(municipalityTax);
            return CreatedAtRoute(
                  "Get",
                  new { Id = municipalityTax.ID },
                  municipalityTax);
        }
        // PUT: api/Municipality/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] MunicipalityTax municipalityTax)
        {
            if (municipalityTax == null)
            {
                log.LogInformation("Unsuccessful PUT because of missing input parameters");
                return BadRequest("Tax record is null.");
            }
            MunicipalityTax municipalityTaxToUpdate = _dataRepository.Get(id);
            if (municipalityTaxToUpdate == null)
            {
                log.LogInformation("Unsuccessful PUT because of wrong input ID");
                return NotFound("The tax record couldn't be found.");
            }
            _dataRepository.Update(municipalityTaxToUpdate, municipalityTax);
            return Ok(municipalityTax);
        }
        // DELETE: api/MunicipalityTax/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            MunicipalityTax municipalityTax = _dataRepository.Get(id);
            if (municipalityTax == null)
            {
                log.LogInformation("Unsuccessful DELETE because of wrong input ID");
                return NotFound("The tax record couldn't be found.");
            }
            _dataRepository.Delete(municipalityTax);
            return Ok("The tax record has been deleted");
        }
    }
}
