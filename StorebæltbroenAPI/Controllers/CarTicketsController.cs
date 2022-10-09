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
        [HttpGet("Licensplate")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public Car GetAllCarsByLicensplate(string plate)
        {
            return mrg.GetCarByLicensplate(plate);
        }

        // POST api/<TicketsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        public Car Post([FromBody] Car c)
        {
            return mrg.CreateTicket(c);
        }

        // PUT api/<TicketsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE api/<TicketsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
