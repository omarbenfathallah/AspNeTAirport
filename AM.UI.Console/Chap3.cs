using AM.ApplicationCore;
using AM.ApplicationCore.Domain;
using AM.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.Console
{
    internal class Chap3
    {
        public static void Test1()
        {
            using(var context = new Context())
            {
                context.Planes.AddRange (InMemorySource.Boeing1, InMemorySource.Boeing2, InMemorySource.Airbus);
                context.Flights.AddRange(InMemorySource.Flights);
                context.Staffs.AddRange(InMemorySource.Staffs);
                context.Travellers.AddRange(InMemorySource.Travellers);

                context.SaveChanges();
            }
        }
        public static void Test2()
        {
            using (var context = new Context())
            {
                context.Tickets.ToList().ShowList("=== Tickets list ===", System.Console.WriteLine);
            }
        }
    }
}
