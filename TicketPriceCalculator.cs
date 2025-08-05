class TicketPriceCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("🎟️ Welcome to the Ticket Price Calculator");
        Console.Write("Please enter your age: ");

        string input = Console.ReadLine();
        int age;

        if (int.TryParse(input, out age))
        {
            double ticketPrice = 10.0; // Base price in GHC

            if (age <= 12)
            {
                ticketPrice -= 7.0; // 50% discount
                Console.WriteLine("Child discount applied (7cedis).");
            }
            else if (age >= 60)
            {
                ticketPrice -= 7.0; // 30% discount
                Console.WriteLine("Senior discount applied (30%).");
            }
            else
            {
                Console.WriteLine("Standard adult ticket.");
            }

            Console.WriteLine($"🎫 Your ticket price is: GHC {ticketPrice:F2}");
        }
        else
        {
            Console.WriteLine("❌ Invalid input. Please enter a valid age.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
