using TicketSystemClassLibrary.Model;

namespace StorebæltbroenAPI.Manager
{
    public interface ICar
    {
        Car CreateTicket(Car newcarticket);

        List<Car> GetAllCarTickets();

        Car GetCarByLicensplate(string licensplate);

        Car DeleteCar(string licensplate);

        Car UpdateCar(string licensplate, Car updatedcar);
    }
}
