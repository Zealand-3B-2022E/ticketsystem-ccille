using TicketSystemClassLibrary.Model;

namespace StoreBaeltTicketLibrary_
{
    public class StoreBaeltCar :Vehicles
    {
        public override double Price(bool brobiz)
        {
            bool saturday = false;
            bool sunday = false;

            if (saturday == true || sunday == true || brobiz == true)
            {
                return 240 * 0.80 * 0.95;

            }

            if (saturday == false || sunday == false)
            {
                return 240;
            }

            return 240;
        }

        public override string VehicleType()
        {
            throw new NotImplementedException();
        }
    }
}