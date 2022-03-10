using System;
namespace MalmoUniversity
{
    class Album
    {
        private string albumName;
        private string artistName;
        private int numOfTracks;
        public Album()
        {
            Console.WriteLine("\x1b[1mStarting the Album Program!\n\x1b[0m");
            Console.WriteLine("What is the name of your favorite music album?");
            albumName = Console.ReadLine();
            Console.WriteLine($"What is the name of the Artist or Band for {albumName}?");
            artistName = Console.ReadLine();
            Console.WriteLine($"How many tracks does {albumName} have?");
            string intValue = Console.ReadLine();
            numOfTracks = int.Parse(intValue);
        }
        public void present()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Album Name: {albumName}");
            Console.WriteLine($"Artist/Band: {artistName}");
            Console.WriteLine($"Number of Tracks: {numOfTracks}");
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("* Enjoy listening *");
        }

    }

}