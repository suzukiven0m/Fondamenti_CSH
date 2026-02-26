namespace Table;
// Chiedi all'utente un numero intero da 1 a 10.
// Stampa tutta la tabellina di quel numero, da 1 a 10.
// Esempio: se l'utente inserisce 6, stampa:  6 x 1 = 6  6 x 2 = 12  ... fino a  6 x 10 = 60
// Se il numero non è tra 1 e 10, mostra un messaggio di errore.
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