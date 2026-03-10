using System;
using System.Collections.Generic;

namespace MathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n=== MATH LIBRARY MENU ===");
                Console.WriteLine("1. Power (Potenza)");
                Console.WriteLine("2. Square Root (Radice Quadrata)");
                Console.WriteLine("3. GCD - Greatest Common Divisor (MCD)");
                Console.WriteLine("4. LCM - Least Common Multiple (MCM)");
                Console.WriteLine("5. Prime Numbers up to N (Crivello)");
                Console.WriteLine("6. Prime Factorization (Scomposizione)");
                Console.WriteLine("0. Exit");
                Console.Write("Select option: ");
                
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Invalid. Enter a number: ");
                }

                switch (choice)
                {
                    case 1: TestPower(); break;
                    case 2: TestSquareRoot(); break;
                    case 3: TestGCD(); break;
                    case 4: TestLCM(); break;
                    case 5: TestPrimes(); break;
                    case 6: TestFactorization(); break;
                    case 0: Console.WriteLine("Goodbye!"); break;
                    default: Console.WriteLine("Invalid option."); break;
                }
            } while (choice != 0);
        }

        static void TestPower()
        {
            Console.Write("Enter base: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter exponent: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Result: {Power(b, e)}");
        }

        static void TestSquareRoot()
        {
            Console.Write("Enter number: ");
            double n = Convert.ToDouble(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Error: negative number.");
                return;
            }
            Console.WriteLine($"Square root: {SquareRoot(n)}");
        }

        static void TestGCD()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"GCD: {GCD(a, b)}");
        }

        static void TestLCM()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"LCM: {LCM(a, b)}");
        }

        static void TestPrimes()
        {
            Console.Write("Enter limit N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> primes = PrimeNumbers(n);
            Console.WriteLine("Prime numbers:");
            for (int i = 0; i < primes.Count; i++)
            {
                Console.Write(primes[i] + " ");
            }
            Console.WriteLine();
        }

        static void TestFactorization()
        {
            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine("Number must be >= 2");
                return;
            }
            List<int> factors = PrimeFactorization(n);
            Console.WriteLine("Prime factors:");
            for (int i = 0; i < factors.Count; i++)
            {
                Console.Write(factors[i] + " ");
            }
            Console.WriteLine();
        }

        // Calculate power with positive or negative exponent
        static double Power(double baseNum, int exp)
        {
            if (exp == 0) return 1;
            
            bool negative = false;
            if (exp < 0)
            {
                negative = true;
                exp = -exp; // Make positive
            }
            
            double result = 1;
            for (int i = 0; i < exp; i++)
            {
                result = result * baseNum;
            }
            
            if (negative)
                return 1 / result;
            return result;
        }

        // Calculate square root using Newton-Raphson method
        static double SquareRoot(double n)
        {
            if (n == 0) return 0;
            
            double x = n / 2; // Initial guess
            double diff;
            
            do
            {
                double nextX = (x + n / x) / 2;
                diff = nextX * nextX - n;
                
                if (diff < 0) diff = -diff;
                
                x = nextX;
            } while (diff >= 0.0001); 
            
            return x;
        }
        
        static int GCD(int a, int b)
        {
            if (a < 0) a = -a;
            if (b < 0) b = -b;
            
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        
        static int LCM(int a, int b)
        {
            if (a == 0 || b == 0) return 0;
            
            int gcd = GCD(a, b);
            int product = a * b;
            if (product < 0) product = -product; // Absolute value
            
            return product / gcd;
        }
        
        static List<int> PrimeNumbers(int n)
        {
            List<int> primes = new List<int>();
            if (n < 2) return primes;
            
            bool[] isPrime = new bool[n + 1];
            
            for (int i = 2; i <= n; i++)
                isPrime[i] = true;
            
            for (int i = 2; i * i <= n; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= n; j = j + i)
                        isPrime[j] = false;
                }
            }
            
            for (int i = 2; i <= n; i++)
                if (isPrime[i]) primes.Add(i);
            
            return primes;
        }
        
        static List<int> PrimeFactorization(int n)
        {
            List<int> factors = new List<int>();
            
            while (n % 2 == 0)
            {
                factors.Add(2);
                n = n / 2;
            }
            
            int divisor = 3;
            while (divisor * divisor <= n)
            {
                while (n % divisor == 0)
                {
                    factors.Add(divisor);
                    n = n / divisor;
                }
                divisor = divisor + 2; 
            }
            
            if (n > 1)
                factors.Add(n);
            
            return factors;
        }
    }
}