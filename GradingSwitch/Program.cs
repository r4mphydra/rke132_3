using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your mark?");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());
            switch(userResult)
            {
                case ('A'):
                    Console.WriteLine("Great job!");
                    break;
                case ('B'):
                    Console.WriteLine("Well done!");
                    break;
                case ('C'):
                    Console.WriteLine("Good!");
                    break;
                case ('D'):
                    Console.WriteLine("Passable.");
                    break;
                case ('E'):
                    Console.WriteLine("Poor.");
                    break;
                case ('F'):
                    Console.WriteLine("Incoplete");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.WriteLine("Have a good day.");
        }
    }
}
