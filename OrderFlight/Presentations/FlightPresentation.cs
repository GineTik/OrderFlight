using OrderFlight.Models;

namespace OrderFlight.Presentations
{
    public class FlightPresentation : ISinglePresentation<Flight>, IManyPresentation<Flight>
    {
        public void Present(Flight model)
        {
            Console.WriteLine($"Номер рейсу: {model.Id}");
            Console.WriteLine($"Дата відправки: {model.DateOfDeparture}");
            Console.WriteLine($"Літак: {model.Plane.Name}");
            new TicketPresentation().Present(model.Plane.Tickets);
        }

        public void Present(IEnumerable<Flight> models)
        {
            Console.WriteLine();
            foreach (var model in models)
            {
                Present(model);
                Console.WriteLine();
            }
        }
    }
}
