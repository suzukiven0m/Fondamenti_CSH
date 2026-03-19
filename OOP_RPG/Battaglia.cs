namespace OOP_RPG;

internal class Battaglia
{
    // Campi
    private Personaggio giocatore1;
    private Personaggio giocatore2;
    private int turno;

    // Costruttore
    public Battaglia(Personaggio p1, Personaggio p2)
    {
        giocatore1 = p1;
        giocatore2 = p2;
        turno = 0;
    }

    // Metodo Simula
    public Personaggio Simula()
    {
        Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                    ⚔️ BATTAGLIA INIZIATA ⚔️                  ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");
        Console.WriteLine();
        Console.WriteLine($"  COMBATTENTE 1: {giocatore1}");
        Console.WriteLine($"  COMBATTENTE 2: {giocatore2}");
        Console.WriteLine();
        Console.WriteLine("───────────────────────────────────────────────────────────────");

        // Determina chi inizia in base alla velocità (HP per semplicità)
        Personaggio attaccante = giocatore1.HPMax >= giocatore2.HPMax ? giocatore2 : giocatore1;
        Personaggio difensore = giocatore1.HPMax >= giocatore2.HPMax ? giocatore1 : giocatore2;

        Console.WriteLine($"{attaccante.Nome} inizia per primo!\n");

        // Loop della battaglia
        while (giocatore1.IsVivo && giocatore2.IsVivo)
        {
            turno++;
            Console.WriteLine($"--- TURNO {turno} ---");

            // Attacco dell'attaccante
            Console.WriteLine($"{attaccante.Nome} attacca {difensore.Nome}!");
            int danno = attaccante.Attacca(difensore);
            Console.WriteLine($"  Danno inflitto: {danno} HP");
            Console.WriteLine($"  {difensore.StatoBreve()}");

            // Controlla se il difensore è morto
            if (!difensore.IsVivo)
            {
                break;
            }

            // Cura occasionale (20% di probabilità se HP bassi)
            Random random = new Random();
            if (random.Next(1, 101) <= 20 && attaccante.HP < attaccante.HPMax / 2)
            {
                attaccante.Cura(15);
            }

            // Scambia i ruoli per il prossimo turno
            (attaccante, difensore) = (difensore, attaccante);
            Console.WriteLine();
        }

        // Fine battaglia
        Console.WriteLine("═══════════════════════════════════════════════════════════════");
        Console.WriteLine("                     ⚔️ BATTAGLIA FINITA ⚔️");
        Console.WriteLine("═══════════════════════════════════════════════════════════════");

        Personaggio vincitore = giocatore1.IsVivo ? giocatore1 : giocatore2;
        Personaggio perdente = giocatore1.IsVivo ? giocatore2 : giocatore1;

        Console.WriteLine($"\n  VINCITORE: {vincitore.Nome} [{vincitore.Classe}]");
        Console.WriteLine($"  Sconfitto: {perdente.Nome}");
        Console.WriteLine($"  Turni totali: {turno}\n");

        // Il vincitore sale di livello
        vincitore.SaliDiLivello();

        return vincitore;
    }
}
