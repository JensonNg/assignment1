using System;

namespace MalmoUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");
            Pet pet = new Pet();
            Console.Clear();
            pet.present();
            Console.WriteLine("Press ENTER to start next part");
            Console.ReadLine();
            TicketSeller ticketSeller = new TicketSeller();
            Console.Clear();
            ticketSeller.present();
            Console.WriteLine("Press ENTER to start next part");
            Console.ReadLine();
            Album album = new Album();
            Console.Clear();
            album.present();
        }
    }
}
