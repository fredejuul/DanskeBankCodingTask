﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DanskeBankCodingTask.Models;
using DanskeBankCodingTask.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DanskeBankCodingTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MunicipalTaxController : ControllerBase
    {
        private readonly IDataRepository<MunicipalityTax> _dataRepository;

        public MunicipalTaxController(IDataRepository<MunicipalityTax> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        // GET: api/Employee
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<MunicipalityTax> municipalityTaxes = _dataRepository.GetAll();
            return Ok(municipalityTaxes);
        }
        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            MunicipalityTax municipalityTax = _dataRepository.Get(id);
            if (municipalityTax == null)
            {
                return NotFound("The tax record couldn't be found.");
            }
            return Ok(municipalityTax);
        }
        // POST: api/Employee
        [HttpPost]
        public IActionResult Post([FromBody] MunicipalityTax municipalityTax)
        {
            if (municipalityTax == null)
            {
                return BadRequest("Tax record is not complete.");
            }
            _dataRepository.Add(municipalityTax);
            return CreatedAtRoute(
                  "Get",
                  new { Id = municipalityTax.ID },
                  municipalityTax);
        }
        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] MunicipalityTax municipalityTax)
        {
            if (municipalityTax == null)
            {
                return BadRequest("Tax record is null.");
            }
            MunicipalityTax municipalityTaxToUpdate = _dataRepository.Get(id);
            if (municipalityTaxToUpdate == null)
            {
                return NotFound("The Tax record couldn't be found.");
            }
            _dataRepository.Update(municipalityTaxToUpdate, municipalityTax);
            return NoContent();
        }
        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            MunicipalityTax municipalityTax = _dataRepository.Get(id);
            if (municipalityTax == null)
            {
                return NotFound("The Tax record couldn't be found.");
            }
            _dataRepository.Delete(municipalityTax);
            return NoContent();
        }
    }
}
