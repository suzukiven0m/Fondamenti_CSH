namespace Number_Descomposition
{
    internal class Program
    {
        ////Chiedi all'utente di inserire un numero intero positivo a tre cifre (es. 347). Usando la
        //divisione intera e il modulo, estrai separatamente le centinaia, le decine e le unità.Stampa
        //ogni cifra su una riga separata. Esempio: 347 → centinaia: 3, decine: 4, unità: 7.




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
          