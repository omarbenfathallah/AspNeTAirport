using AM.ApplicationCore;
using AM.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.Console
{
    internal class Chap2
    {
        static ShowLine showLine = System.Console.WriteLine;
        public static void Test1()
        {
            var flightService = new BasicFlightService(InMemorySource.Flights, showLine);

            flightService.ShowFlights("Destination", "Paris");
            flightService.ShowFlights("Destination", "Madrid");
            flightService.ShowFlights("FlightId", "3");
        }
        public static void Test2()
        {
            var flightService = new BasicFlightService(InMemorySource.Flights, showLine);

            flightService.GetDurationsInMinutes().ShowList("== GetDurationsInMinutes ==", showLine);
            flightService.GetFlightsSortedByDuration().ShowList("== GetFlightsSortedByDuration ==", showLine);
            new[] { flightService.GetDurationsAverage() }.ShowList("== GetDurationsAverage ==", showLine);
            flightService.GetDurationsInMinutesLINQ().ShowList("== GetDurationsInMinutesLINQ ==", showLine);
        }
    }
}
