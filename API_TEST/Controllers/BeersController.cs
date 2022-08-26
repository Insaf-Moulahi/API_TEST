using API_TEST.BreweryData;
using API_TEST.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API_TEST.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class BeersController : ControllerBase
    {
        private IBeer _ibeer;
        public BeersController(IBeer ibeer)
        {
            _ibeer = ibeer;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetBeers()
        {
            return Ok(_ibeer.GetBeers());
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetBeer(Guid id)
        {
            var beer = _ibeer.GetBeer(id);
            if (beer != null)
            { return Ok(beer); }
            else { return NotFound($"Beer with id: {id} was not found"); }
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult GetBeer(Beer _beer)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            _ibeer.AddBeer(_beer);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + _beer.ID, _beer);

        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteBeer(Guid id)
        {
            var beer = _ibeer.GetBeer(id);
            if (beer != null)
            { _ibeer.DeleteBeer(beer); return Ok(); }
            return NotFound($"Beer with id: {id} was not found");
        }
        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditBeer(Guid id, Beer beer)
        {
            var existe_beer = _ibeer.GetBeer(id);
            if (existe_beer != null)
            {
                beer.ID = existe_beer.ID;
                _ibeer.EditBeer(beer);
            }
            return Ok(beer);
        }
    }
}
