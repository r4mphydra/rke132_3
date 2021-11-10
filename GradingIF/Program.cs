using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell us your mark.");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());
            if( userResult == 'A')
            {
                Console.WriteLine("Great job!");
            }
     else if(userResult == 'B')
            {
                Console.WriteLine("Well done!");
            }
      else  if(userResult == 'C')
            {
                Console.WriteLine("Good!");
           }
      else  if(userResult == 'D')
            {
                Console.WriteLine("Passable.");
            }
       else if(userResult == 'E')
            {
                Console.WriteLine("Poor.");
            }
       else if(userResult == 'F')
            {
                Console.WriteLine("Incoplete");
            }
           else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("Have a good day.");
        }
    }
}
