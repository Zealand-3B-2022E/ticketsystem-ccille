using Microsoft.AspNetCore.Mvc;
using StorebæltbroenAPI.Manager;
using TicketSystemClassLibrary.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StorebæltbroenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarTicketsController : ControllerBase
    {
        private CarManager mrg = new CarManager();

        // GET: api/<TicketsController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IEnumerable<Car> GetAllCars()
        {
            return mrg.GetAllCarTickets();
        }

        // GET api/<TicketsController>/5
        [HttpGet]
        [Route("licensplate")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetAllCarsByLicensplate(string plate)
        {
            try
            {
                Car car = mrg.GetCarByLicensplate(plate);
                return Ok(car);
            }
            catch (KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }
        }

        // POST api/<TicketsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public IActionResult Post([FromBody] Car c)
        {
            try
            {
                Car newcar = mrg.CreateTicket(c);
                string uri = "api/Tickets/" + c.LicensPlate;
                return Created(uri, newcar);
            }
            catch (ArgumentException ae)
            {

                return Conflict(ae.Message);
            }
        }

        // PUT api/<TicketsController>/5
        [HttpPut]
        [Route("{licensplate}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Put(string licensplate, [FromBody] Car c)
        {
            try
            {
                return Ok(mrg.UpdateCar(licensplate, c));
            }
            catch (KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }
        }

        // DELETE api/<TicketsController>/5
        [HttpDelete]
        [Route("{licensplate}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(string licensplate)
        {
            try
            {
                return Ok(mrg.DeleteCar(licensplate));
            }
            catch (KeyNotFoundException knfe)
            {
                return NotFound(knfe.Message);
            }
        }
    }
}
