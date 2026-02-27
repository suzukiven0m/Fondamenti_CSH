namespace Table;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please insert a number from 1 to 10: ");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input is < 1 or > 10)
        {
            Console.WriteLine("Invalid input");
        }
        else
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{input} x {i}  = {input * i}");
            }
        }
    }
}