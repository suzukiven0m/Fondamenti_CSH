namespace Discount
{
    internal class Program
    {
        //// Chiedi all'utente il prezzo unitario di un prodotto e la quantità desiderata. Calcola il totale,
        //poi applica uno sconto del 10% se il totale supera 50 euro.Stampa il totale scontato.
        //BONUS: usa anche bool haSconto per indicare se lo sconto è stato applicato.
        static void Main(string[] args)
        {

            Console.WriteLine("Inserisci il prezzo unitario del prodotto: ");
            int prezzoUnitario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci la quantità desiderata: ");
            int quantita = Convert.ToInt32(Console.ReadLine());
            int sub_totale = prezzoUnitario * quantita;
            bool haSconto = sub_totale > 50;
            if (haSconto)
            {
                double totaleScontato = sub_totale * 0.9;
                Console.WriteLine($"Il totale scontato è: {totaleScontato} euro");
            }
            else
            {
                Console.WriteLine($"Il totale è: {sub_totale} euro");
            }

        }
    }
}