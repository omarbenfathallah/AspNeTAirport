using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IplaneService : IService<Plane>
    {
        IEnumerable<Plane> PlaneBefore3ans();
        IEnumerable<Flight> FlightParxCapacite(int capa);
    }
}
