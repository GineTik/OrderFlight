using OrderFlight.Factories;
using OrderFlight.Helpers;
using OrderFlight.Models;
using OrderFlight.Presentations;
using System.Text;

namespace OrderFlight
{
    public class Application
    {
        private readonly List<Flight> _flights = FlightHelper.GetFlights();
        private readonly Client _client = ClientHelper.GetClient();

        public void Run()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            new FlightPresentation().Present(_flights);

            var flight = SelectFlight();
            var ticket = SelectTicket(flight);
            new TicketPresentation().Present(ticket);

            var card = SelectCard(_client);
        }

        private Flight SelectFlight()
        {
            Console.Write("Виберіть рейс: ");
            var flightNumber = uint.Parse(Console.ReadLine());

            var selectedFlight = _flights.FirstOrDefault(x => x.Id == flightNumber);
            if (selectedFlight == null)
                throw new ArgumentOutOfRangeException("такого рейсу не існує");

            return selectedFlight;
        }

        private Ticket SelectTicket(Flight flight)
        {
            Console.Write("Виберіть місце: ");
            var seatNumber = uint.Parse(Console.ReadLine());

            var selectedTicket = flight.Tickets.FirstOrDefault(x => x.SeatNumber == seatNumber);
            if (selectedTicket == null)
                throw new ArgumentOutOfRangeException("такого місця не існує");

            return selectedTicket;
        }

        private Card SelectCard(Client client)
        {
            Console.Write("Виберіть карту: ");
            var cardId = uint.Parse(Console.ReadLine());

            var selectedCard = client.Cards.FirstOrDefault(x => x.Id == cardId);
            if (selectedCard == null)
                throw new ArgumentOutOfRangeException("такої карти не існує");

            return selectedCard;
        }
    }
}
