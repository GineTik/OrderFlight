using OrderFlight.Models;

namespace OrderFlight.Helpers
{
    public class ClientHelper
    {
        public static Client GetClient()
        {
            return new Client()
            {
                BoughtTickets = new(),
                Cards = new()
                {
                    new Card()
                    {
                        Id = 1,
                        Fullname = "Peter Parker",
                        Number = "0000 0000 0000 0000",
                        CVC = 616,
                        ValidUntil = DateTime.Parse("11.11.2023"),
                        Money = 5400,
                    },

                    new Card()
                    {
                        Id = 2,
                        Fullname = "Peter Parker",
                        Number = "1111 1111 1111 1111",
                        CVC = 713,
                        ValidUntil = DateTime.Parse("11.11.2023"),
                        Money = 100,
                    },

                    new Card()
                    {
                        Id = 3,
                        Fullname = "Peter Parker",
                        Number = "1234 1234 1234 1234",
                        CVC = 233,
                        ValidUntil = DateTime.Parse("11.11.2025"),
                        Money = 450,
                    },
                },
            };
        }
    }
}
