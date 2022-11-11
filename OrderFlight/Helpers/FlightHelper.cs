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
                    Id = 1,
                    Plane = planes.First(x => x.Name == "Plane #1"),
                    DateOfDeparture = DateTime.Parse("13.11.2022"),
                },

                new Flight()
                {
                    Id = 2,
                    Plane = planes.First(x => x.Name == "Plane #1"),
                    DateOfDeparture = DateTime.Parse("14.11.2022"),
                },

                new Flight()
                {
                    Id = 3,
                    Plane = planes.First(x => x.Name == "Plane #2"),
                    DateOfDeparture = DateTime.Parse("12.11.2022"),
                },

                new Flight()
                {
                    Id = 4,
                    Plane = planes.First(x => x.Name == "Plane #3"),
                    DateOfDeparture = DateTime.Parse("16.11.2022"),
                },
            };
        }
    }
}
