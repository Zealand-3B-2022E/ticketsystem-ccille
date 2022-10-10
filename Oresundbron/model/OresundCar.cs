using TicketSystemClassLibrary.Model;

namespace Oresundbron
{
    public class OresundCar :Vehicles
    {
        public override double Price(bool brobiz)
        {
            if (brobiz == true)
            {
                return 161;
            }
            return 410;
        }

        public override string VehicleType()
        {
            return "Oresund Car";
        }
    }
}