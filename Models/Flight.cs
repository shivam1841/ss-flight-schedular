namespace Stealth_Startup.Models
{
    public class Flight
    {
        public int FlightNo;
        public string Departure;
        public string Arrival;
        public int FlightDay;
        public int FlightBoxCapacity;

        public Flight(int flightNo, string departure, string arrival, int day, int capactiy)
        {
            FlightNo = flightNo;
            Departure = departure;
            Arrival = arrival;
            FlightDay = day;
            FlightBoxCapacity = capactiy;
        }

        public override string ToString()
        {
            var text = "Flight: " + FlightNo;
            text += ", departure: " + Departure;
            text += ", arrival: " + Arrival;
            text += ", day: " + FlightDay;
            return text;
        }
    }

    public class FlightSchedule
    {

    }
}