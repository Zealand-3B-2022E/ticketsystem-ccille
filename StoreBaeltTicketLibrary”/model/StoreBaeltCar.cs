using TicketSystemClassLibrary.Model;

namespace StoreBaeltTicketLibrary_
{
    public class StoreBaeltCar :Car
    {
        public override double Price(bool brobiz)
        {
            bool saturday = false;
            bool sunday = false;
            double price = 240;

            if (saturday == true || sunday == true || brobiz)
            {
                price = price * 0.80 * 0.95;

            }

            

            return price;
        }


    }
}