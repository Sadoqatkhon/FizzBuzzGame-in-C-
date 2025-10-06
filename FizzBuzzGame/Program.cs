using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's start our FizzBuzz Game!");
            Console.Write("Enter a number limit for the game: ");
            int gameStop = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Great");
            Console.Write("What is our Fizz: ");
            int fizz = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.Write("What is our Buzz: ");
            int buzz = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Awesome. Let's start");

            for (int i = 1; i <= gameStop; i++)
            {
                bool fizzDiv = i % fizz == 0;
                bool buzzDiv = i % buzz == 0;

                if (fizzDiv && buzzDiv)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fizzDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if (buzzDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }                
            }
            
            Console.WriteLine();
            Console.WriteLine("Here we go.Game is over");
            Console.ReadLine();

        }
    }
}
