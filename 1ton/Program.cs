using System;

namespace _1ton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert any positive number: ");
            int input = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= input; i++)
            {
                var type = (i % 2 == 0) ? "even" : "odd";
                sum = sum + i;
                Console.WriteLine($"{i} is {type}");

            }

            Console.WriteLine($"Sum is {sum}");
        }
    }
}