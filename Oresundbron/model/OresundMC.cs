using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary.Model;

namespace Oresundbron.model
{
    public class OresundMC : Vehicles
    {
        public override double Price(bool brobiz)
        {
            if (brobiz == true)
            {
                return 73;
            }
            return 210;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
