using System.Text;
using System.Text.Json;

namespace Stealth_Startup.Models
{
    public class Persistence
    {
        public List<Order> LoadOrdersFromFile(string city)
        {
            List<Order> orders = new List<Order>();
            Console.WriteLine("Order Processing Started...");
            string text = File.ReadAllText(getFileName(city), Encoding.UTF8);
            var values = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string,string>>>(text);
            foreach(var v in values) 
            {   
                Order order = new Order(v.Key, 0, city, v.Value["destination"], 0);
                orders.Add(order);
            }
            Console.WriteLine("Order Processing Finished.");
            return orders;
        }
        public List<Flight> GetFlightsForCity(string city)
        {
            List<Flight> flights = new List<Flight>();
            flights.Add(new Flight(1, city, "YYZ", 1, 20));
            flights.Add(new Flight(2, city, "YYC", 1, 20));
            flights.Add(new Flight(3, city, "YVR", 1, 20));
            flights.Add(new Flight(4, city, "YYZ", 2, 20));
            flights.Add(new Flight(5, city, "YYC", 2, 20));
            flights.Add(new Flight(6, city, "YVR", 2, 20));
            return flights;
        }

        public string getFileName(string city)
        {
            return @"Resources/" + city + ".json";
        }
    }
}