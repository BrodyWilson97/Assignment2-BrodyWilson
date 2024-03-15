public class Flight
{
    public string FlightCode { get; set; }
    public string Airline { get; set; }
    public string OriginAirportCode { get; set; }
    public string DestinationAirportCode { get; set; }
    public string DayOfWeek { get; set; }
    public string DepartureTime { get; set; }
    public decimal Cost { get; set; }
}
public class Airport
{
    public string AirportCode { get; set; }
    public string AirportName { get; set; }
}

