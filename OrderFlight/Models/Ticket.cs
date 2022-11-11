namespace OrderFlight.Models
{
    public class Ticket
    {
        public int SeatNumber { get; set; }
        public decimal Price { get; set; }
        public bool SeatTaken { get; set; }
    }
}
