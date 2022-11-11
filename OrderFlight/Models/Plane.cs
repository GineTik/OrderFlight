namespace OrderFlight.Models
{
    public class Plane
    {
        public string Name { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
