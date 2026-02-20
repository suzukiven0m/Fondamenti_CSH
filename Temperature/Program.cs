namespace Temperature
{
    internal class Program
    {
        //Chiedi all'utente di inserire una temperatura in Celsius. Convertila in Fahrenheit usando la
        //formula: F = (C × 9/5) + 32. Stampa il risultato.Esempio: 100°C = 212°F
        static void Main(string[] args)
        {
            Console.WriteLine("Hello... Please insert a temperature in Celsius: ");
            int temperature = int.Parse(Console.ReadLine()); 
            int temperature_fahreinhet = (temperature * 9 / 5) + 32;
            Console.WriteLine($"The temperature in Fahrenheit is: {temperature_fahreinhet}");

        }
    }
}
