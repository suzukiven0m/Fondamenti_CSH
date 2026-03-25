namespace OOP_Trattoria;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Benvenuto alla trattoria Piazza dei Mestieri\n");

        var menu = new[]
        {
            new Pietanza("Carbonara", 12.50, "Primo"),
            new Pietanza("Pasta con le sarde", 11.00, "Primo"),
            new Pietanza("Coniglio alla cacciatora", 15.00, "Secondo"),
            new Pietanza("Bistecca alla griglia", 18.00, "Secondo"),
            new Pietanza("Pesce spada", 22.00, "Secondo"),
            new Pietanza("Tiramisù", 6.00, "Dolce")
        };

        Console.Write("Inserire il numero di Tavolo che ha prenotato: ");
        var vtavolo = new Tavolo(int.Parse(Console.ReadLine()!));
        Console.WriteLine();

        Console.WriteLine("Il menù del giorno è il seguente:");
        for (int i = 0; i < menu.Length; i++)
            Console.WriteLine($"{i + 1}) {menu[i].Tipo}: {menu[i].Nome}");
        Console.WriteLine();

        int scelta;
        do
        {
            Console.Write("Faccia la sua scelta, 99 per terminare l'ordine: ");
            scelta = int.Parse(Console.ReadLine()!);

            if (scelta >= 1 && scelta <= menu.Length)
            {
                vtavolo.AggiungiPietanza(menu[scelta - 1]);
                Console.WriteLine($"Aggiunto: {menu[scelta - 1].Nome}");
            }
            else if (scelta != 99)
                Console.WriteLine("Scelta non valida!");
        } while (scelta != 99);

        Console.WriteLine();
        vtavolo.StampaDettagli();
    }
}
