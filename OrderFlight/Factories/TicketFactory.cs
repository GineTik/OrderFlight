using OrderFlight.Models;

namespace OrderFlight.Factories
{
    public class TicketFactory
    {
        public IEnumerable<Ticket> Create(int count, decimal price, int lastSeatNumber = 0)
        {
            for (int i = lastSeatNumber; i < count + lastSeatNumber; i++)
            {
                yield return new Ticket()
                {
                    Price = price,
                    SeatNumber = i + 1
                };
            }
        }
    }
}
