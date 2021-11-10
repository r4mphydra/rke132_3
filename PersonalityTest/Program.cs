using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, write your favourite color");
            string userColor = Console.ReadLine().ToLower();
            if(userColor == "red")
            {
                Console.WriteLine("You are romantic.");
            }
            else if(userColor == "blue")
            {
                Console.WriteLine("You are hardworking.");
            }
     else if (userColor == "green")
            {
                Console.WriteLine("You are environmental friendly.");
            }
            else
            {
                Console.WriteLine("You are unicorn.");
            }
        }
    }
}
