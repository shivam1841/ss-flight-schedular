// See https://aka.ms/new-console-template for more information
using Stealth_Startup.Models;
using Stealth_Startup.Services;

Persistence p = new Persistence();
// User Story 1
//List<Flight> flights = p.GetFlightsForCity("YUL");
//Console.Write(string.Join(Environment.NewLine, flights));

// User Story 2
//List<Order> orders = p.LoadOrdersFromFile("YUL");
//Console.Write(string.Join(Environment.NewLine, orders));

AirportService airportService = new AirportService("YUL");

// User Story 1
Console.WriteLine("User Story 1");
airportService.PrintFlights();


// User Story 2
Console.WriteLine("User Story 2");
airportService.PrintOrders();
