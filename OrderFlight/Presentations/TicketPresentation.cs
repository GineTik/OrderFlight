using OrderFlight.Models;

namespace OrderFlight.Presentations
{
    public class TicketPresentation : ISinglePresentation<Ticket>, IManyPresentation<Ticket>
    {
        public void Present(IEnumerable<Ticket> models)
        {
            var minPrice = models.Min(x => x.Price);
            var maxPrice = models.Max(x => x.Price);

            var price = minPrice == maxPrice ? $"{minPrice}" : $"{minPrice} - {maxPrice}";

            Console.WriteLine($"кількість місць: {models.Count()}, ціна: {price}");
            Console.WriteLine($"вільних місць: {models.Count(x => x.SeatTaken == false)}");
        }

        public void Present(Ticket model)
        {
            Console.WriteLine();
            Console.WriteLine($"місце: {model.SeatNumber}, ціна: {model.Price}");
            Console.WriteLine();
        }
    }
}
