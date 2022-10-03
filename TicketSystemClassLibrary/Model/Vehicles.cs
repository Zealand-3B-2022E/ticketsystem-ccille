using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Model
{
    public abstract class Vehicles
    {
        
        public Vehicles()
        {

        }

        /// <summary>
        /// Abstract method for pice
        /// </summary>
        /// <returns>Price in double</returns>
        public abstract  double Price();


        /// <summary>
        /// Abstract method for type of vehicle
        /// </summary>
        /// <returns>Type of vehicle - string</returns>
        public abstract string VehicleType();
    }
}
