namespace Discount
{
    internal class Program
    {
       
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