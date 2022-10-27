using TicketSystemClassLibrary.Model;

namespace StorebæltbroenAPI.Manager
{
    public class CarManager : ICar
    {
        private static List<Car> _cars = new List<Car>()
        {
            new Car("34221SS"),
            new Car("88664TY"),
            new Car("98762EE"),
            new Car("12214JG")
        };


        public Car CreateTicket(Car newcarticket)
        {
            if (_cars.Exists(c => c.LicensPlate == newcarticket.LicensPlate))
            {
                throw new ArgumentException("Licensplate already exist");
            }
            _cars.Add(newcarticket);
            return newcarticket;
        }

        //Står ikke i opgaven
        public Car DeleteCar(string licensplate)
        {
            Car del = GetCarByLicensplate(licensplate);
            _cars.Remove(del);
            return del;
        }

        public List<Car> GetAllCarTickets()
        {
            return _cars; 
        }

        public Car GetCarByLicensplate(string licensplate)
        {
            if (!_cars.Exists(c => c.LicensPlate == licensplate))
            {
                throw new KeyNotFoundException();
            }
            return _cars.Find(c => c.LicensPlate == licensplate);
        }

        //Står ikke i opgaven
        public Car UpdateCar(string licensplate, Car updatedcar)
        {
            Car ca = GetCarByLicensplate(licensplate);
            if (ca is not null)
            {
                ca.LicensPlate = updatedcar.LicensPlate;
                ca.Date = updatedcar.Date;
            }
            return ca;
        }
    }
}
