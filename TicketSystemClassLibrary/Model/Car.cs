namespace TicketSystemClassLibrary.Model
{
    public class Car :Vehicles
    {


        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="licensPlate">car linsensplate</param>
        public Car(string licensplate) :base()
        {
            LicensPlate = licensplate;
        }

        public Car() : base()
        {

        }
        
        /// <summary>
        /// Method for Price - double inherit from vehicle class with bool brobiz
        /// </summary>
        /// <returns>Price 240, broboz discount and weekend discount</returns>
        public override double Price(bool brobiz)
        {

            if (brobiz == true)
            {
                return 240 * 0.95;
            }
            

            return 240;

        }

        /// <summary>
        /// Method for vehicles - string inherit from vehicle class
        /// </summary>
        /// <returns>String "car"</returns>
        public override string VehicleType()
        {
            return "Car";
        }

    }
}