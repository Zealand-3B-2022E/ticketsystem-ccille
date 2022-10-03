using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Model
{
    public class MC : Vehicles
    {
        public string Licensplate { get; set; }

        public DateTime Date { get; private set; }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="licensPlate">MC linsensplate</param>
        /// <param name="date">Date</param>
        public MC(string licensplate, DateTime date)
        {
            Licensplate = licensplate;
            Date = date;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public MC()
        {
        }

        /// <summary>
        /// Method for price - double inherit from vehicle
        /// </summary>
        /// <returns>the price for MC</returns>
        public override double Price()
        {
            return 125;
        }

        /// <summary>
        /// Method for type of vehicle - string inherit from vehicle
        /// </summary>
        /// <returns>type of vehicle MC</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}
