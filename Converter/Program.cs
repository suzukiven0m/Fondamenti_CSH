using System;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(@"
=================================================================================================================================
      ___           ___           ___           ___           ___           ___           ___           ___           ___     
     /\  \         /\  \         /\__\         /\__\         /\  \         /\  \         /\  \         /\  \         /\  \    
    /::\  \       /::\  \       /::|  |       /:/  /        /::\  \       /::\  \        \:\  \       /::\  \       /::\  \   
   /:/\:\  \     /:/\:\  \     /:|:|  |      /:/  /        /:/\:\  \     /:/\:\  \        \:\  \     /:/\:\  \     /:/\:\  \  
  /:/  \:\  \   /:/  \:\  \   /:/|:|  |__   /:/__/  ___   /::\~\:\  \   /::\~\:\  \       /::\  \   /::\~\:\  \   /::\~\:\  \ 
 /:/__/ \:\__\ /:/__/ \:\__\ /:/ |:| /\__\  |:|  | /\__\ /:/\:\ \:\__\ /:/\:\ \:\__\     /:/\:\__\ /:/\:\ \:\__\ /:/\:\ \:\__\
 \:\  \  \/__/ \:\  \ /:/  / \/__|:|/:/  /  |:|  |/:/  / \:\~\:\ \/__/ \/_|::\/:/  /    /:/  \/__/ \:\~\:\ \/__/ \/_|::\/:/  /
  \:\  \        \:\  /:/  /      |:/:/  /   |:|__/:/  /   \:\ \:\__\      |:|::/  /    /:/  /       \:\ \:\__\      |:|::/  / 
   \:\  \        \:\/:/  /       |::/  /     \::::/__/     \:\ \/__/      |:|\/__/     \/__/         \:\ \/__/      |:|\/__/  
    \:\__\        \::/  /        /:/  /       ~~~~          \:\__\        |:|  |                      \:\__\        |:|  |    
     \/__/         \/__/         \/__/                       \/__/         \|__|                       \/__/         \|__|    
==================================================================================================================================
            Welcome to my C# Program, choose a conversion:
            1. Kilometre to Mile
            2. Kilogram to Pound
            3. Litre to Gallon
            4. Exit
        ");
                

                int selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Insert amount of Kms: ");
                        double km = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{km} Kilometres = {(km * 0.621371):0.###} Miles");
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Insert Kgs: ");
                        double kg = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{kg} Kilograms = {(kg * 2.20462):0.###} Pounds");
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Insert Litres: ");
                        double litre = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{litre} Litres = {(litre * 0.264172):0.###} Gallons");
                        break;

                    case 4:
                        return;
                    
                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }

                Console.WriteLine("\nPress any key to return to menu...");
                Console.ReadKey();
            }
        }
    }
}