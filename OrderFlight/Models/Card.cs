namespace OrderFlight.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Number { get; set; }
        public int CVC { get; set; }
        public DateTime ValidUntil { get; set; }
        public decimal Money { get; set; }
    }
}
