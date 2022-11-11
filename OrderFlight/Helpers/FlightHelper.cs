using OrderFlight.Models;

namespace OrderFlight.Helpers
{
    public class FlightHelper
    {
        public static List<Flight> GetFlights()
        {
            var planes = PlaneHelper.GetPlanes();

            return new()
            {
                new Flight()
                {
                    Plane = planes[0],
                    DateOfDeparture = DateTime.Parse("13.11.2022"),
                },

                new Flight()
                {
                    Plane = planes[0],
                    DateOfDeparture = DateTime.Parse("14.11.2022"),
                },

                new Flight()
                {
                    Plane = planes[1],
                    DateOfDeparture = DateTime.Parse("12.11.2022"),
                },

                new Flight()
                {
                    Plane = planes[2],
                    DateOfDeparture = DateTime.Parse("16.11.2022"),
                },
            };
        }
    }
}
