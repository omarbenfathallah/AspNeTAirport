using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class PlaneService : Service<Plane>, IplaneService
    {
        public PlaneService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Plane> PlaneBefore3ans()
        {
            DateTime dt = DateTime.Now;
            return GetMany(plane => plane.ManufactureDate.AddDays(1095) < dt);
        }

        public IEnumerable<Flight> FlightParxCapacite(int capa)
        {
            IEnumerable<Plane> listplane = GetMany(plane => plane.Capacity == capa);
            return listplane.ToList().SelectMany(plane => plane.Flights);
        }


    }
}
