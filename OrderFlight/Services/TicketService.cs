using OrderFlight.Models;

namespace OrderFlight.Services
{
    public class TicketService
    {
        private readonly Client _client;

        public TicketService(Client client) =>
            _client = client ?? throw new ArgumentNullException(nameof(client));

        public void BuyTicket(Ticket ticket, Card card)
        {
            if (ticket == null)
                throw new ArgumentNullException(nameof(ticket));

            if (card == null)
                throw new ArgumentNullException(nameof(card));

            if (card.Money < ticket.Price)
                throw new InvalidCastException("Not enought money");

            card.Money = ticket.Price;
            _client.BoughtTickets.Add(ticket);
        }
    }
}
