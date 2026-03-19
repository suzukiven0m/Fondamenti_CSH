namespace OOP_Universita;

class Program
{
    static Universita universita = new Universita();

    static void Main(string[] args)
    {
        Console.WriteLine("╔══════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║         🎓 SISTEMA DI GESTIONE UNIVERSITARIA 🎓              ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

        // Dati di esempio
        InizializzaDatiEsempio();

        int scelta;
        do
        {
            MostraMenu();
            Console.Write("\nScelta: ");
            
            if (!int.TryParse(Console.ReadLine(), out scelta))
            {
                Console.WriteLine("Input non valido!");
                continue;
            }

            switch (scelta)
            {
                case 1: MenuStudenti(); break;
                case 2: MenuCorsi(); break;
                case 3: GestioneIscrizioni(); break;
                case 4: GestioneVoti(); break;
                case 5: universita.StampaStatistiche(); break;
                case 6: universita.StampaTuttiStudenti(); break;
                case 7: universita.StampaTuttiCorsi(); break;
                case 0: Console.WriteLine("Arrivederci!"); break;
                default: Console.WriteLine("Scelta non valida!"); break;
            }

            if (scelta != 0)
            {
                Console.WriteLine("\nPremi INVIO per continuare...");
                Console.ReadLine();
            }

        } while (scelta != 0);
    }

    static void MostraMenu()
    {
        Console.WriteLine("\n════════════ MENU PRINCIPALE ════════════");
        Console.WriteLine("1. Gestione Studenti");
        Console.WriteLine("2. Gestione Corsi");
        Console.WriteLine("3. Gestione Iscrizioni");
        Console.WriteLine("4. Gestione Voti");
        Console.WriteLine("5. Visualizza Statistiche");
        Console.WriteLine("6. Lista Studenti");
        Console.WriteLine("7. Lista Corsi");
        Console.WriteLine("0. Esci");
    }

    static void MenuStudenti()
    {
        Console.WriteLine("\n--- MENU STUDENTI ---");
        Console.WriteLine("1. Aggiungi Studente");
        Console.WriteLine("2. Rimuovi Studente");
        Console.WriteLine("3. Cerca Studente");
        Console.Write("Scelta: ");

        if (!int.TryParse(Console.ReadLine(), out int scelta)) return;

        switch (scelta)
        {
            case 1:
                Console.Write("Nome: ");
                string nome = Console.ReadLine() ?? "";
                Console.Write("Cognome: ");
                string cognome = Console.ReadLine() ?? "";
                Console.Write("Anno di nascita: ");
                if (int.TryParse(Console.ReadLine(), out int anno))
                {
                    Console.Write("Matricola: ");
                    string matricola = Console.ReadLine() ?? "";
                    universita.AggiungiStudente(new Studente(nome, cognome, anno, matricola));
                }
                break;

            case 2:
                Console.Write("Matricola da rimuovere: ");
                universita.RimuoviStudente(Console.ReadLine() ?? "");
                break;

            case 3:
                Console.Write("Matricola da cercare: ");
                var studente = universita.TrovaStudente(Console.ReadLine() ?? "");
                Console.WriteLine(studente?.ToString() ?? "Studente non trovato.");
                break;
        }
    }

    static void MenuCorsi()
    {
        Console.WriteLine("\n--- MENU CORSI ---");
        Console.WriteLine("1. Aggiungi Corso");
        Console.WriteLine("2. Rimuovi Corso");
        Console.WriteLine("3. Cerca Corso");
        Console.Write("Scelta: ");

        if (!int.TryParse(Console.ReadLine(), out int scelta)) return;

        switch (scelta)
        {
            case 1:
                Console.Write("Codice: ");
                string codice = Console.ReadLine() ?? "";
                Console.Write("Nome: ");
                string nome = Console.ReadLine() ?? "";
                Console.Write("Crediti (CFU): ");
                if (!int.TryParse(Console.ReadLine(), out int cfu)) return;
                Console.Write("Professore: ");
                string prof = Console.ReadLine() ?? "";
                Console.Write("Max Studenti: ");
                if (!int.TryParse(Console.ReadLine(), out int max)) return;
                universita.AggiungiCorso(new Corso(codice, nome, cfu, prof, max));
                break;

            case 2:
                Console.Write("Codice da rimuovere: ");
                universita.RimuoviCorso(Console.ReadLine() ?? "");
                break;

            case 3:
                Console.Write("Codice da cercare: ");
                var corso = universita.TrovaCorso(Console.ReadLine() ?? "");
                Console.WriteLine(corso?.ToString() ?? "Corso non trovato.");
                break;
        }
    }

    static void GestioneIscrizioni()
    {
        Console.WriteLine("\n--- GESTIONE ISCRIZIONI ---");
        Console.WriteLine("1. Iscrivi Studente a Corso");
        Console.WriteLine("2. Disiscrivi Studente da Corso");
        Console.Write("Scelta: ");

        if (!int.TryParse(Console.ReadLine(), out int scelta)) return;

        Console.Write("Matricola studente: ");
        var studente = universita.TrovaStudente(Console.ReadLine() ?? "");
        if (studente == null)
        {
            Console.WriteLine("Studente non trovato!");
            return;
        }

        Console.Write("Codice corso: ");
        var corso = universita.TrovaCorso(Console.ReadLine() ?? "");
        if (corso == null)
        {
            Console.WriteLine("Corso non trovato!");
            return;
        }

        if (scelta == 1)
        {
            studente.IscrivitiACorso(corso);
        }
        else if (scelta == 2)
        {
            studente.DisiscrivitiDaCorso(corso);
        }
    }

    static void GestioneVoti()
    {
        Console.WriteLine("\n--- GESTIONE VOTI ---");
        Console.Write("Matricola studente: ");
        var studente = universita.TrovaStudente(Console.ReadLine() ?? "");
        if (studente == null)
        {
            Console.WriteLine("Studente non trovato!");
            return;
        }

        if (studente.CorsiSeguiti.Count == 0)
        {
            Console.WriteLine("Lo studente non è iscritto a nessun corso!");
            return;
        }

        Console.WriteLine("Corsi seguiti:");
        for (int i = 0; i < studente.CorsiSeguiti.Count; i++)
        {
            var c = studente.CorsiSeguiti[i];
            Console.WriteLine($"{i + 1}. {c.Nome} (Voto attuale: {c.GetVotoStudente(studente)})");
        }

        Console.Write("Seleziona corso (numero): ");
        if (!int.TryParse(Console.ReadLine(), out int scelta) || scelta < 1 || scelta > studente.CorsiSeguiti.Count)
        {
            Console.WriteLine("Scelta non valida!");
            return;
        }

        var corso = studente.CorsiSeguiti[scelta - 1];
        Console.Write("Inserisci voto (0-30): ");
        if (int.TryParse(Console.ReadLine(), out int voto) && voto >= 0 && voto <= 30)
        {
            corso.AssegnaVoto(studente, voto);
            Console.WriteLine($"Voto {voto} assegnato a {studente.Nome} per il corso {corso.Nome}");
        }
        else
        {
            Console.WriteLine("Voto non valido!");
        }
    }

    static void InizializzaDatiEsempio()
    {
        // Studenti
        universita.AggiungiStudente(new Studente("Mario", "Rossi", 2000, "MAT001"));
        universita.AggiungiStudente(new Studente("Anna", "Bianchi", 1999, "MAT002"));
        universita.AggiungiStudente(new Studente("Luca", "Verdi", 2001, "MAT003"));
        universita.AggiungiStudente(new Studente("Giulia", "Neri", 2000, "MAT004"));

        // Corsi
        universita.AggiungiCorso(new Corso("INF101", "Programmazione I", 12, "Smith", 30));
        universita.AggiungiCorso(new Corso("INF102", "Programmazione II", 12, "Johnson", 25));
        universita.AggiungiCorso(new Corso("MAT101", "Analisi Matematica", 9, "Euler", 50));
        universita.AggiungiCorso(new Corso("FIS101", "Fisica I", 9, "Newton", 40));
        universita.AggiungiCorso(new Corso("ING101", "Inglese Tecnico", 6, "Brown", 20));

        // Iscrizioni e voti di esempio
        var s1 = universita.TrovaStudente("MAT001")!;
        var s2 = universita.TrovaStudente("MAT002")!;
        var s3 = universita.TrovaStudente("MAT003")!;
        var s4 = universita.TrovaStudente("MAT004")!;

        var c1 = universita.TrovaCorso("INF101")!;
        var c2 = universita.TrovaCorso("INF102")!;
        var c3 = universita.TrovaCorso("MAT101")!;
        var c4 = universita.TrovaCorso("FIS101")!;
        var c5 = universita.TrovaCorso("ING101")!;

        // Iscrizioni
        s1.IscrivitiACorso(c1); s1.IscrivitiACorso(c3); s1.IscrivitiACorso(c4);
        s2.IscrivitiACorso(c1); s2.IscrivitiACorso(c2); s2.IscrivitiACorso(c5);
        s3.IscrivitiACorso(c1); s3.IscrivitiACorso(c2); s3.IscrivitiACorso(c3); s3.IscrivitiACorso(c4);
        s4.IscrivitiACorso(c2); s4.IscrivitiACorso(c3); s4.IscrivitiACorso(c5);

        // Voti
        c1.AssegnaVoto(s1, 25); c3.AssegnaVoto(s1, 22); c4.AssegnaVoto(s1, 20);
        c1.AssegnaVoto(s2, 28); c2.AssegnaVoto(s2, 26); c5.AssegnaVoto(s2, 30);
        c1.AssegnaVoto(s3, 18); c2.AssegnaVoto(s3, 24); c3.AssegnaVoto(s3, 19); c4.AssegnaVoto(s3, 21);
        c2.AssegnaVoto(s4, 27); c3.AssegnaVoto(s4, 23); c5.AssegnaVoto(s4, 29);

        Console.WriteLine("\n✅ Dati di esempio caricati!");
    }
}
