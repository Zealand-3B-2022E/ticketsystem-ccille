using TicketSystemClassLibrary.Model;

namespace StorebæltbroenAPI.Manager
{
    public interface IMC
    {
        MC CreateMCTicket(MC newmcticket);

        List<MC> GetAllMCTickets();

        MC GetMCByLicensplate(string licensplate);
    }
}
