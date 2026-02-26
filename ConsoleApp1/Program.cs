using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GuessNumber();

        }

        static void GuessNumber()
        {
            int guess = 10;
            int number;
            int tries = 0;

            Console.WriteLine("Insert a number from 1 to 98, 99 to quit: ");
            number = int.Parse(Console.ReadLine());

            while (number != 99)
            {
                tries++;

                if (number == guess)
                {
                    Console.Clear();
                    Console.WriteLine("You got the number right!");
                    Console.WriteLine("Number of tries: " + tries);
                    break;

                }
                else if (number > guess)
                {
                    Console.WriteLine("Number too high!");
                }
                else
                {
                    Console.WriteLine("Number too low!");
                }

                Console.WriteLine("Insert a number from 1 to 98, 99 to quit: ");
                number = int.Parse(Console.ReadLine());
            }

            if (number == 99)
            {
                Console.Clear();
                Console.WriteLine("Game over!");
                Console.WriteLine($" You tried {tries - 1} times!");
            }

        }
    }
}