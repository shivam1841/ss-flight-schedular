namespace Stealth_Startup.Models
{
    public class Order
    {
        public string OrderNumber;
        public int FlightNumber;
        public string Source;
        public string Destination;
        public int FlightDay;
        public Order(string orderNumber, int flightNumber, string source, string destination, int day)
        {
            OrderNumber = orderNumber ?? throw new ArgumentNullException(paramName: nameof(orderNumber));
            FlightNumber = flightNumber;
            Source = source;
            Destination = destination;
            FlightDay = day;
        }

        public override string ToString()
        {
            var text = "order: " + OrderNumber;
            if(FlightNumber != 0)
            {
                text   += ", flightNumber: " + FlightNumber;
                text += ", departure: " + Source;
                text += ", arrival: " + Destination;
                text += ", day: " + FlightDay;
            } else {
                text   += ", flightNumber: not scheduled";
            }
            return text;
        }
    }
}