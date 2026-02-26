namespace Number_Descomposition
{
    internal class Program
    {
        


        static void Main(string[] args)
        {
            Console.WriteLine("Hello... Please insert a positive whole number of three numbers (Ex. 347)");
            int number = Convert.ToInt32(Console.ReadLine());
            int hundreds = number / 100;
            int tens = (number % 100) / 10;
            int units = number % 10;
            Console.WriteLine($"Hundreds: {hundreds}");
            Console.WriteLine($"Tens: {tens}");
            Console.WriteLine($"Units: {units}");
        }
    }
}
          