namespace OOP_RPG;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                   🎮 RPG BATTLE SIMULATOR 🎮                   ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
        Console.WriteLine();

        // Creazione personaggi di tipi diversi
        Console.WriteLine("=== CREAZIONE PERSONAGGI ===\n");

        Personaggio guerriero = new Personaggio("Thorin", "Guerriero");
        Personaggio mago = new Personaggio("Gandalf", "Mago");
        Personaggio ladro = new Personaggio("Legolas", "Ladro");
        Personaggio chierico = new Personaggio("Elrond", "Chierico");

        // Mostra statistiche iniziali
        Console.WriteLine("Statische iniziali:");
        Console.WriteLine(guerriero);
        Console.WriteLine(mago);
        Console.WriteLine(ladro);
        Console.WriteLine(chierico);
        Console.WriteLine();

        Console.WriteLine("--- Inizia la prima battaglia ---\n");

        // Battaglia 1: Guerriero vs Mago
        Battaglia battaglia1 = new Battaglia(guerriero, mago);
        Personaggio vincitore1 = battaglia1.Simula();

        Console.WriteLine("\n--- Prossima battaglia ---\n");

        // Battaglia 2: Ladro vs Chierico
        Battaglia battaglia2 = new Battaglia(ladro, chierico);
        Personaggio vincitore2 = battaglia2.Simula();

        Console.WriteLine("\n--- Finale del Torneo ---\n");

        // Finale: Vincitori si affrontano
        Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                   🏆 FINALE DEL TORNEO 🏆                     ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════╝\n");

        Console.WriteLine($"Combattente 1: {vincitore1}");
        Console.WriteLine($"Combattente 2: {vincitore2}\n");

        Battaglia finale = new Battaglia(vincitore1, vincitore2);
        Personaggio campione = finale.Simula();

        // Schermata finale
        Console.WriteLine("\n");
        Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                     👑 CAMPIONE ASSOLUTO 👑                   ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
        Console.WriteLine($"\n        {campione.Nome} [{campione.Classe}] - Livello {campione.Livello}");
        Console.WriteLine($"        {campione}");
        Console.WriteLine("\n           🎉 Congratulazioni al vincitore! 🎉\n");
    }
}
