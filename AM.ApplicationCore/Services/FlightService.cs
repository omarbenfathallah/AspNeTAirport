using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class FlightService : Service<Flight>, IFlightService
    {
        public FlightService(IUnitOfWork unitOfWork): base(unitOfWork)
        { 

        }

        public IEnumerable<Flight> GetFlightsByDestination(string destination)
        {
            return GetMany(flight => flight.Destination == destination);
        }
    }
}
