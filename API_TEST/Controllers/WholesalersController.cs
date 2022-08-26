using API_TEST.BreweryData;
using API_TEST.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API_TEST.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class WholesalersController : ControllerBase
    {
        private IWholesaler _iWholesaler;
        public WholesalersController(IWholesaler iWholesaler)
        {
            _iWholesaler = iWholesaler;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetWholesalers()
        {
            return Ok(_iWholesaler.GetWholesalers());
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetWholesaler(Guid id)
        {
            var wholesaler = _iWholesaler.GetWholesaler(id);
            if (wholesaler != null)
            { return Ok(wholesaler); }
            else { return NotFound($"wholesaler with id: {id} was not found"); }
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Addwholesaler(Wholesaler _wholesaler)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            _iWholesaler.AddWholesaler(_wholesaler);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + _wholesaler.ID, _wholesaler);

        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteWholesaler(Guid id)
        {
            var wholesaler = _iWholesaler.GetWholesaler(id);
            if (wholesaler != null)
            { _iWholesaler.DeleteWholesaler(wholesaler); return Ok(); }
            return NotFound($"Wholesaler with id: {id} was not found");
        }
        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditWholesaler(Guid id, Wholesaler wholesaler)
        {
            var existe_wholesaler = _iWholesaler.GetWholesaler(id);
            if (existe_wholesaler != null)
            {
                wholesaler.ID = existe_wholesaler.ID;
                _iWholesaler.EditWholesaler(wholesaler);
            }
            return Ok(wholesaler);
        }
    }
}
