namespace Temperature
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello... Please insert a temperature in Celsius: ");
            int temperature = int.Parse(Console.ReadLine()); 
            int temperatureFahreinhet = (temperature * 9 / 5) + 32;
            Console.WriteLine($"The temperature in Fahrenheit is: {temperatureFahreinhet}");

        }
    }
}
