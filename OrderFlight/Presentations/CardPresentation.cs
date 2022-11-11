using OrderFlight.Models;

namespace OrderFlight.Presentations
{
    public class CardPresentation : IManyPresentation<Card>
    {
        public void Present(IEnumerable<Card> models)
        {
            Console.WriteLine();
            foreach (var model in models)
                Console.WriteLine($"номер карти: {model.Number}, коштів на карті: {model.Money}");
            Console.WriteLine();
        }
    }
}
