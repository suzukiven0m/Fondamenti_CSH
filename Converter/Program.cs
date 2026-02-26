namespace Converter
{
    internal class Program
    {

       
        static void Main(string[] args)
        {
            Console.WriteLine("What type of converter do you want:");
            Console.WriteLine("1. Kilometre to Mile");
            Console.WriteLine("2. Kilogram to Pound");
            Console.WriteLine("3. Litre to Gallon");

            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Insert amount of Kms to be converted to miles: ");
                    double kmConvert = double.Parse(Console.ReadLine());
                    double milesConvert = kmConvert * 0.621371;
                    Console.Clear();
                    Console.WriteLine($"{kmConvert} Kilometres = {milesConvert.ToString("0.###")} Miles");
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Insert Kgs to be converted to pounds: ");
                    double kgsConvert = double.Parse(Console.ReadLine());
                    double poundsConvert = kgsConvert * 2.20462;
                    Console.Clear();
                    Console.WriteLine($"{kgsConvert} Kilograms = {poundsConvert.ToString("0.###")} Pounds");
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Litres to be converted to Gallons: ");
                    double litreConvert = double.Parse(Console.ReadLine());
                    double gallonConvert = litreConvert * 0.264172;
                    Console.Clear();
                    Console.WriteLine($"{litreConvert} Litres = {gallonConvert.ToString("0.###")} Gallons");
                    break;

                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }
    }
}