using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Model
{
    public class MC : Vehicles
    {
       
        public MC(string licensplate) :base()
        {
            LicensPlate = licensplate;
        }

        public MC()
        {

        }


        /// <summary>
        /// Method for price - double inherit from vehicle with bool for brobiz
        /// </summary>
        /// <returns>the price for MC</returns>
        public override double Price(bool brobiz)
        {
            if (brobiz == true)
            {
                return 125 * 0.95;
            }
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
