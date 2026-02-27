using System;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a positive number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers up to " + number + ":");

            for (int i = 2; i <= number; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}