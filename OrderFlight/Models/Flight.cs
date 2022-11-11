namespace OrderFlight.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public Plane Plane { get; set; }
        public DateTime DateOfDeparture { get; set; }
        public List<Ticket> Tickets => Plane.Tickets;
    }
}
