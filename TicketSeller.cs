using System;
namespace MalmoUniversity
{
    class TicketSeller
    {
        private string name;
        private double price = 100;
        private int numOfAdults;
        private int numOfChildren;

        private double amountToPay;

        public TicketSeller()
        {
            Console.WriteLine("\x1b[1mWelcome to the JJ's concert!\n\x1b[0m");
            Console.WriteLine("With this concert, children get always discount 50%!\n");
            Console.WriteLine("Your name please:");
            name = Console.ReadLine();
            Console.WriteLine("Number of adults:");
            string intValue = Console.ReadLine();
            numOfAdults = int.Parse(intValue);
            Console.WriteLine("Number of children:");
            intValue = Console.ReadLine();
            numOfChildren = int.Parse(intValue);

            double total = (numOfAdults * price) + ((numOfChildren * price) / 2);
            amountToPay = total;

        }

        public void present()
        {
            Console.WriteLine("+++ Your receipt +++");
            Console.WriteLine($"+++ Amount to pay: {amountToPay}\n");
            Console.Write($"+++ Thank you {name} and see you in the concert +++\n");
        }
    }
}
