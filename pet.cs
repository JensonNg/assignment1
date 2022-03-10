using System;
namespace MalmoUniversity
{

    class Pet
    {
        private string name;
        private int age;
        private bool isFemale;

        public Pet()
        {
            Console.WriteLine("\x1b[1mWelcome to the Louis's pet class!\n\x1b[0m");
            Console.WriteLine("What is your pet name?");
            name = Console.ReadLine();
            Console.WriteLine($"How nice the name is! What is {name}'s age?");
            string textValue = Console.ReadLine();
            age = int.Parse(textValue);
            Console.WriteLine("Is your pet a female (y/n)?");
            string strGender = Console.ReadLine();
            strGender = strGender.Trim();
            char response = strGender[0];

            if ((response == 'y') || (response == 'Y'))
                isFemale = true;
            else
                isFemale = false;



        }

        public void present()
        {
            Console.WriteLine("=====================");
            Console.WriteLine($"Pet's Name: {name}\n" + $"Age: {age}");
            if (isFemale == true)
            {
                Console.Write($"{name} belong to the girl's club!\n");
            }

            else
            {
                Console.Write($"{name} is a good boy!\n");
            }
            Console.WriteLine("=====================");
        }
    }

}