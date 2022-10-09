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
        [HttpGet("Licensplate")]
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
        public MC Post([FromBody] MC mc)
        {
            return mrg.CreateMCTicket(mc);
        }

        // PUT api/<MCTicketsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<MCTicketsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
