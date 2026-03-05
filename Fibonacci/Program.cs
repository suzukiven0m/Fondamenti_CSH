namespace Fibonacci;

class Program
{
    static void Main(string[] args)
    {
        string? choice;

        do
        {
            Console.WriteLine(@"
        ,--.   ,--.,------.,--.  ,--.,--. ,--. 
        |   `.'   ||  .---'|  ,'.|  ||  | |  | 
        |  |'.'|  ||  `--, |  |' '  ||  | |  | 
        |  |   |  ||  `---.|  | `   |'  '-'  ' 
        `--'   `--'`------'`--'  `--' `-----'  
        1. Calculate factorial of N.
        2. Print N fibonacci numbers.
        0. Quit.");

            Console.Write("\n        Choose an option: ");
            choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    Console.Write("        Enter N: ");
                    if (int.TryParse(Console.ReadLine(), out int factN) && factN >= 0)
                    {
                        long result = Factorial(factN);
                        Console.WriteLine($"        {factN}! = {result}\n");
                    }
                    else
                    {
                        Console.WriteLine("        Please enter a valid non-negative integer.\n");
                    }
                    break;

                case "2":
                    Console.Write("        Enter N: ");
                    if (int.TryParse(Console.ReadLine(), out int fibN) && fibN >= 0)
                    {
                        Console.Write("        Fibonacci: ");
                        PrintFibonacci(fibN);
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("        Please enter a valid non-negative integer.\n");
                    }
                    break;

                case "0":
                    Console.WriteLine("        Goodbye!\n");
                    break;

                default:
                    Console.WriteLine("        Invalid option. Please choose 0, 1 or 2.\n");
                    break;
            }

        } while (choice != "0");
    }
    
    static long Factorial(int n)
    {
        if (n == 0) return 1;
        long result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;
        return result;
    }
    
    static void PrintFibonacci(int n)
    {
        if (n == 0)
        {
            Console.Write("0");
            return;
        }

        long a = 0, b = 1;
        for (int i = 0; i <= n - 1; i++)
        {
            Console.Write(i == 0 ? $"{a}" : $", {a}");
            long temp = a + b;
            a = b;
            b = temp;
        }
    }
}