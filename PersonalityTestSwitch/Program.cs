using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write your favourite color");
            string userColor = Console.ReadLine().ToLower();
            switch (userColor)
            {
                case ("red"):
                    Console.WriteLine("You are romantic.");
                    break;
                case ("blue"):
                    Console.WriteLine("You are hardworking.");
                    break;
                case ("green"):
                    Console.WriteLine("You are environmental friendly.");
                    break;
                default:
                    Console.WriteLine("You are unicorn.");
                    break;
            }
            Console.WriteLine("Have a good day.");
        }
    }
}
