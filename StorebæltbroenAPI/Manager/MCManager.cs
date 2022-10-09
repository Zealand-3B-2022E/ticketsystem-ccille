using TicketSystemClassLibrary.Model;

namespace StorebæltbroenAPI.Manager
{
    public class MCManager : IMC
    {
        private static List<MC> _mc = new List<MC>()
        {
            new MC("4477ED"),
            new MC("45666AC"),
            new MC("27711NN"),
            new MC("4178FDR"),
        };

        public MC CreateMCTicket(MC newmcticket)
        {
            if (_mc.Exists(mc => mc.LicensPlate == newmcticket.LicensPlate))
            {
                throw new ArgumentException("Licensplate already exist");
            }
            _mc.Add(newmcticket);
            return newmcticket;
        }

        public List<MC> GetAllMCTickets()
        {
            return _mc;
        }

        public MC GetMCByLicensplate(string licensplate)
        {
            if (!_mc.Exists(mc => mc.LicensPlate == licensplate))
            {
                throw new KeyNotFoundException();
            }
            return _mc.Find(mc => mc.LicensPlate == licensplate);
        }
    }
}
