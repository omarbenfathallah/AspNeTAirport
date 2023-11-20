using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public static class InMemorySource
    {
        public static readonly Flight Flight1 = new Flight { FlightDate = new DateTime(2022, 1, 1, 15, 10, 0), Destination = "Paris", EffectiveArrival = new DateTime(2022, 1, 1, 17, 10, 0), EstimatedDuration = 2, Departure ="Tunis" };
        public static readonly Flight Flight2 = new Flight { FlightDate = new DateTime(2022, 1, 1, 21, 10, 0), Destination = "Paris", EffectiveArrival = new DateTime(2022, 1, 1, 23, 10, 0), EstimatedDuration = 2, Departure = "Tunis" };
        public static readonly Flight Flight3 = new Flight { FlightDate = new DateTime(2022, 1, 1, 5, 10, 0), Destination = "Paris", EffectiveArrival = new DateTime(2022, 1, 1, 7, 10, 0), EstimatedDuration = 2, Departure = "Tunis" };
        public static readonly Flight Flight4 = new Flight { FlightDate = new DateTime(2022, 1, 1, 6, 10, 0), Destination = "Madrid", EffectiveArrival = new DateTime(2022, 1, 1, 8, 40, 0), EstimatedDuration = 2.5f, Departure = "Tunis" };
        public static readonly Flight Flight5 = new Flight { FlightDate = new DateTime(2022, 1, 1, 17, 10, 0), Destination = "Madrid", EffectiveArrival = new DateTime(2022, 1, 1, 19, 40, 0), EstimatedDuration = 2.5f, Departure = "Tunis" };
        public static readonly Flight Flight6 = new Flight { FlightDate = new DateTime(2022, 1, 1, 20, 10, 0), Destination = "Lisbonne", EffectiveArrival = new DateTime(2022, 1, 1, 23, 10, 0), EstimatedDuration = 3, Departure = "Tunis" };
        public static Plane Boeing1 { get; private set; } = GetFirstPlane();
        public static readonly Plane Boeing2 = new Plane(PlaneType.Boeing, 150, new DateTime(2015, 2, 3)) { Flights = new List<Flight> { Flight3, Flight4 } };
        public static readonly Plane Airbus = new Plane() {PlaneType = PlaneType.Airbus, Capacity = 250, ManufactureDate = new DateTime(2020, 11, 11), Flights = new List<Flight> { Flight5, Flight6 } };
        public static readonly Staff CaptainStaff = new Staff {FullName = new FullName { FirstName = "captain", LastName = "Captain" }, EmailAddress = "captain@gmail.com", BirthDate = new DateTime(1965, 1, 1), EmployementDate = new DateTime(1999, 1, 1), Salary = 10000, PassportNumber = "p1" };
        public static readonly Staff Hostess1Staff = new Staff { FullName = new FullName { FirstName = "hostess1", LastName = "Hostess1" }, EmailAddress = "hostess1@gmail.com", BirthDate = new DateTime(1995, 1, 1), EmployementDate = new DateTime(2019, 1, 1), Salary = 5000, PassportNumber = "p2" };
        public static readonly Staff Hostess2Staff = new Staff { FullName = new FullName { FirstName = "hostess2", LastName = "Hostess2" }, EmailAddress = "hostess2@gmail.com", BirthDate = new DateTime(1996, 1, 1), EmployementDate = new DateTime(2018, 1, 1), Salary = 6000, PassportNumber = "p3" };
        public static readonly Traveller Traveller1 = new Traveller { FullName = new FullName { FirstName = "traveller1", LastName = "Traveller1" }, BirthDate = new DateTime(1980, 1, 1), HealthInformation = "No troubles", Nationality = "American", PassportNumber = "p4" };
        public static readonly Traveller Traveller2 = new Traveller { FullName = new FullName { FirstName = "traveller2", LastName = "Traveller2" }, BirthDate = new DateTime(1981, 1, 1), HealthInformation = "Some troubles", Nationality = "French", PassportNumber = "p5" };
        public static readonly Traveller Traveller3 = new Traveller { FullName = new FullName { FirstName = "traveller3", LastName = "Traveller3" }, BirthDate = new DateTime(1982, 1, 1), HealthInformation = "No troubles", Nationality = "Tunisian", PassportNumber = "p6" };
        public static readonly Traveller Traveller4 = new Traveller { FullName = new FullName { FirstName = "traveller4", LastName = "Traveller4" }, BirthDate = new DateTime(1983, 1, 1), HealthInformation = "Some troubles", Nationality = "American", PassportNumber = "p7" };
        public static readonly Traveller Traveller5 = new Traveller { FullName = new FullName { FirstName = "traveller5", LastName = "Traveller5" }, BirthDate = new DateTime(1984, 1, 1), HealthInformation = "Some troubles", Nationality = "Spanish", PassportNumber = "p8" };
        public static readonly IList<Staff> Staffs = new List<Staff> { CaptainStaff, Hostess1Staff, Hostess2Staff };
        public static readonly IList<Traveller> Travellers = new List<Traveller> { Traveller1, Traveller2, Traveller3, Traveller4, Traveller5 };
        public static readonly IList<Flight> Flights = new List<Flight> { Flight1, Flight2, Flight3, Flight4, Flight5, Flight6 };
        static InMemorySource()
        {
            Flight1.Plane = Boeing1;
            Flight2.Plane = Boeing1;
            Flight3.Plane = Boeing2;
            Flight4.Plane = Boeing2;
            Flight5.Plane = Airbus;
            Flight6.Plane = Airbus;
        }
        static Plane GetFirstPlane()
        {
            Plane plane = new Plane();

            plane.PlaneType = PlaneType.Boeing;
            plane.Capacity = 200;
            plane.ManufactureDate = new DateTime(2019, 12, 31);
            plane.Flights = new List<Flight> { Flight1, Flight2 };

            return plane;
        }
    }
}
