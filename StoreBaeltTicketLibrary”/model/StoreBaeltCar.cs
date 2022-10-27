using TicketSystemClassLibrary.Model;

namespace StoreBaeltTicketLibrary_
{
    public class StoreBaeltCar :Car
    {
        public override double Price(bool brobiz)
        {
            bool saturday = false;
            bool sunday = false;

            if (saturday == true || sunday == true || brobiz)
            {
                return 240 * 0.80 * 0.95;

            }

            if (saturday == false || sunday == false)
            {
                return 240;
            }

            return 240;
        }


    }
}