using API_TEST.BreweryData;
using API_TEST.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TEST.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]

    public class BreweriesController : ControllerBase
    {
        private Ibrewery _ibrewery;
        public BreweriesController(Ibrewery ibrewery)
        {
            _ibrewery = ibrewery;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetBreweries()
        {
            return Ok(_ibrewery.GetBreweries());
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetBrewery(Guid id)
        {
            var brewery = _ibrewery.GetBrewery(id);
            if(brewery!=null)
            { return Ok(brewery); }
            else { return NotFound($"Brewery with id: {id} was not found"); }

            
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetBrewery(Brewery _brewery)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            _ibrewery.AddBrewery(_brewery);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + _brewery.Id, _brewery);

        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteBrewery(Guid id)
        {
            var brewery = _ibrewery.GetBrewery(id);
            if(brewery!=null)
            { _ibrewery.DeleteBrewery(brewery); return Ok(); }
            return NotFound($"Brewery with id: {id} was not found");
        }
        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditBrewery(Guid id, Brewery brewery)
        {
            var existe_brewery = _ibrewery.GetBrewery(id);
            if (existe_brewery != null)
            {
                brewery.Id = existe_brewery.Id;
                _ibrewery.EditBrewery(brewery);
            }
            return Ok(brewery);
        }
    }
}
