using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class BasicFlightService : IBasicFlightService
    {
        ICollection<Flight> source;
        ShowLine showLine;
        public BasicFlightService(ICollection<Flight> source, ShowLine showLine)
        {
            this.source = source;
            this.showLine = showLine;
        }
        public void ShowFlights(string filterType, string filterValue)
        {
            showLine($"=== Filter type : {filterType}, Filter value : {filterValue} ===");

            switch(filterType)
            {
                case "Destination":
                    foreach (Flight item in source)
                    {
                        if (item.Destination == filterValue)
                        {
                            showLine(item);
                        }
                    }
                    break;
                case "FlightDate":
                    DateTime flightDate = DateTime.Parse(filterValue);

                    foreach (Flight item in source)
                    {
                        if (item.FlightDate == flightDate)
                        {
                            showLine(item);
                        }
                    }
                    break;
                case "FlightId":
                    int flightId = int.Parse(filterValue);

                    foreach (Flight item in source)
                    {
                        if (item.FlightId == flightId)
                        {
                            showLine(item);
                        }
                    }
                    break;
                default:
                    throw new ArgumentException("Unknown filter");
            }
        }
        public IEnumerable<object> GetDurationsInMinutes()
        {
            return source.Select(e => new { e.FlightId, EstimatedDurationInMinutes = 60 * e.EstimatedDuration });
        }
        public IEnumerable<Flight> GetFlightsSortedByDuration()
        {
            return source.OrderByDescending(e => e.EstimatedDuration);
        }
        public float GetDurationsAverage()
        {
            return source.Average(e => e.EstimatedDuration);
        }
        public IEnumerable<object> GetDurationsInMinutesLINQ()
        {
            return from e in source select new { e.FlightId, EstimatedDurationInMinutes = 60 * e.EstimatedDuration };
        }
    }
}
