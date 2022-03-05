using Stealth_Startup.Models;
using System.Linq;

namespace Stealth_Startup.Services
{
    public interface IFlightService
    {
        public void LoadFlights();
        public void PrintFlights();
    }

    public interface IOrderService
    {
        public void LoadOrders();
        public void PrintOrders();
        public void ScheduleOrders();
    }
    public class AirportService : IFlightService, IOrderService
    {
        List<Flight> flights = new List<Flight>();
        List<Order> orders = new List<Order>();
        private string _city;
        private readonly Persistence _p = new Persistence();

        public AirportService(string cityName)
        {
            _city = cityName;
            LoadFlights();
            LoadOrders();
            ScheduleOrders();
        }
       
        public void LoadFlights() => flights = _p.GetFlightsForCity(_city);
        public void LoadOrders() => orders = _p.LoadOrdersFromFile(_city);
        public void PrintFlights() => Console.WriteLine(string.Join(Environment.NewLine, flights));
        public void PrintOrders() => Console.WriteLine(string.Join(Environment.NewLine, orders));

        public void ScheduleOrders()
        {
           foreach(var order in orders)
           {
               var flightIndex = flights.FindIndex(e => e.Arrival == order.Destination && e.FlightBoxCapacity > 0);
               if(flightIndex != -1)
               {
                   // Map flight to order
                   order.FlightNumber = flights[flightIndex].FlightNo;
                   order.FlightDay = flights[flightIndex].FlightDay;
                   --flights[flightIndex].FlightBoxCapacity;
               }
           }
        }
  }
}