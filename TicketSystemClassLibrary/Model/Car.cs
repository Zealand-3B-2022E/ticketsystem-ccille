namespace TicketSystemClassLibrary.Model
{
    public class Car :Vehicles
    {
        public string LicensPlate { get; private set; }

        public DateTime Date { get; private set; }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="licensPlate">car linsensplate</param>
        /// <param name="date">Date</param>
        public Car(string licensPlate, DateTime date)
        {
            LicensPlate = licensPlate;
            Date = date;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Car() 
        {
        }


        /// <summary>
        /// Method for Price - double inherit from vehicle class
        /// </summary>
        /// <returns>Price 240</returns>
        public override double Price()
        {
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