using OrderFlight.Factories;
using OrderFlight.Models;

namespace OrderFlight.Helpers
{
    // для прикладу
    public class PlaneHelper
    {
        public static List<Plane> GetPlanes()
        {
            return new List<Plane>()
            {
                new Plane()
                {
                    Name = "Plane #1",
                    Tickets = new TicketFactory().Create(112, 400).ToList(),
                },

                new Plane()
                {
                    Name = "Plane #2",
                    Tickets = new TicketFactory().Create(150, 350).ToList(),
                },

                new Plane()
                {
                    Name = "Plane #3",
                    Tickets =
                        new TicketFactory().Create(60, 300)
                        .Concat(new TicketFactory().Create(40, 550, lastSeatNumber: 60))
                        .ToList(),
                },
            };
        }
    }
}
