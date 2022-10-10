using Microsoft.AspNetCore.Mvc;
using StorebæltbroenAPI.Manager;
using TicketSystemClassLibrary.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StorebæltbroenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MCTicketsController : ControllerBase
    {
        private MCManager mrg = new MCManager();

        // GET: api/<MCTicketsController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IEnumerable<MC> GetAllMCTickets()
        {
            return mrg.GetAllMCTickets();
        }

        // GET api/<MCTicketsController>/5
        [HttpGet]
        [Route("Licensplate")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetMCByLicensplate(string plate)
        {
            try
            {
                MC Mc = mrg.GetMCByLicensplate(plate);
                return Ok(Mc);
            }
            catch (KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }

        }

        // POST api/<MCTicketsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public IActionResult Post([FromBody] MC mc)
        {
            try
            {
                MC newmc = mrg.CreateMCTicket(mc);
                string uri = "api/Tickets/" + mc.LicensPlate;
                return Created(uri, newmc);
            }
            catch (ArgumentException ae)
            {

                return Conflict(ae.Message);
            }
        }

        // PUT api/<MCTicketsController>/5
        [HttpPut]
        [Route("{licensplate}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Put(string licensplate, [FromBody] MC mc)
        {
            try
            {
                return Ok(mrg.UpdateMC(licensplate, mc));
            }
            catch (KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }
        }

        // DELETE api/<MCTicketsController>/5
        [HttpDelete]
        [Route("{licensplate}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(string licensplate)
        {
            try
            {
                return Ok(mrg.DeleteMC(licensplate));
            }
            catch (KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }
        }
    }
}
