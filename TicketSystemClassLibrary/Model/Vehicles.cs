using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Model
{
    public abstract class Vehicles
    {

        public string LicensPlate { get; set; }

        public DateTime Date { get; set; }


        public Vehicles()
        {

        }

        public Vehicles(string Licensplate)
        {
            if (Licensplate.Length > 7 )
            {
                throw new ArgumentException("Licensplate can not be more than 7 characters");

            }
            this.LicensPlate = Licensplate;

        }


        /// <summary>
        /// Abstract method for pice
        /// </summary>
        /// <returns>Price in double</returns>
        public abstract double Price(bool Brobiz);


        /// <summary>
        /// Abstract method for type of vehicle
        /// </summary>
        /// <returns>Type of vehicle - string</returns>
        public abstract string VehicleType();

        
    }
}
