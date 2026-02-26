using System;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please insert a positive integer: ");
            int N = int.Parse(Console.ReadLine());

            if (N <= 0)
            {
                Console.WriteLine("Number must be positive.");
                return;
            }

            
            bool isNPrime = IsPrime(N);
            Console.WriteLine(isNPrime ? $"{N} is prime." : $"{N} is not prime.");
            
            Console.WriteLine($"\nPrime numbers up to {N}:");
            int primeCount = 0;
            for (int num = 2; num <= N; num++)
            {
                if (IsPrime(num))
                {
                    Console.WriteLine(num);
                    primeCount++;
                }
            }
            Console.WriteLine($"\nTotal prime numbers up to {N}: {primeCount}");
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