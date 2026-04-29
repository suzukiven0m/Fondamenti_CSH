namespace OOP_Ereditarieta;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SCATOLA SEMPLICE ===");
        var scatola = new Scatola
        {
            Lunghezza = 3,
            Larghezza = 3,
            Altezza = 4
        };
        Console.WriteLine(scatola.Info());

        Console.WriteLine("\n=== SCATOLA SEMPLICE CON SPEDIZIONE ===");
        var sscs = new ScatoleSempliceConSpedizione
        {
            Lunghezza = 3,
            Larghezza = 3,
            Altezza = 4,
            Corriere = "DHL",
            Indirizzo = "Via Roma 1",
            CostoSpedizione = 12.5
        };
        Console.WriteLine(sscs.Info());

        Console.WriteLine("\n=== SCATOLA SEMPLICE CON ASSICURAZIONE ===");
        var ssca = new ScatolaSempliceConAssicurazione
        {
            Lunghezza = 5,
            Larghezza = 4,
            Altezza = 3,
            NomeAssicurazione = "AXA",
            ValoreAssicurato = 500,
            PremioAssicurazione = 25
        };
        Console.WriteLine(ssca.Info());
    }
}