using System;

namespace _1ton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please insert any positive number: ");
            int input = int.Parse(Console.ReadLine());
            int somma = 0;

            for (int i = 1; i <= input; i++)
            {
                somma += i;
                string tipo = (i % 2 == 0) ? "even" : "odd";
                Console.WriteLine($"{i} - {tipo}");
            }

            Console.WriteLine($"Total sum: {somma}");
        }
    }
}