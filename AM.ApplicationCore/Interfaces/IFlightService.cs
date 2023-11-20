using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IFlightService : IService<Flight>
    {
        IEnumerable<Flight> GetFlightsByDestination(string destination);
    }
}
