using AM.ApplicationCore;
using AM.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore.Query.Internal;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;

namespace AM.UI.Console
{
    public class Chap4
    {

        public static void Test1()
        {
            // Créer une nouvelle unité de travail
            using (var unitOfWork = new UnitOfWork())
            {
                unitOfWork.Repository<Plane>().Add(InMemorySource.Boeing1);
                unitOfWork.Repository<Plane>().Add(InMemorySource.Boeing2);

                unitOfWork.Repository<Plane>().Add(InMemorySource.Airbus);
                unitOfWork.Commit();
            }
        }


        public static void Test2()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                IFlightService flightService = new FlightService(unitOfWork);

                var flightsToParis = flightService.GetFlightsByDestination("Paris");

                flightsToParis.ShowList("== GetFlightsByDestination ==", System.Console.WriteLine);
            }
        }
        public static void Test4()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                IplaneService planeService = new PlaneService(unitOfWork);

                var planebefore = planeService.FlightParxCapacite(200);

                planebefore.ShowList("== plane par capacité ==", System.Console.WriteLine);
            }
        }
        public static void Test3()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                IplaneService planeService = new PlaneService(unitOfWork);

                var planebefore = planeService.PlaneBefore3ans();

                planebefore.ShowList("== plane before 3ans ==", System.Console.WriteLine);
            }
        }
        public static void Test5()
        {
            using(var unitOfWork = new UnitOfWork())
            {
                TicketService planeservice = new TicketService(unitOfWork);
                planeservice.getvippassenger().ShowList("== vip ==", System.Console.WriteLine);
            }
        }
    }
}
