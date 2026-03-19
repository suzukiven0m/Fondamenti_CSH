namespace OOP_Universita;

internal class Universita
{
    // Liste
    private List<Studente> studenti;
    private List<Corso> corsi;

    // Costruttore
    public Universita()
    {
        studenti = new List<Studente>();
        corsi = new List<Corso>();
    }

    // ========== CRUD STUDENTI ==========

    // Create
    public void AggiungiStudente(Studente studente)
    {
        if (studente != null && !studenti.Any(s => s.Matricola == studente.Matricola))
        {
            studenti.Add(studente);
            Console.WriteLine($"Studente {studente.Nome} {studente.Cognome} aggiunto!");
        }
        else
        {
            Console.WriteLine("Studente già esistente o dati non validi!");
        }
    }

    // Read
    public Studente? TrovaStudente(string matricola)
    {
        return studenti.FirstOrDefault(s => s.Matricola == matricola);
    }

    // Read all
    public List<Studente> GetTuttiStudenti()
    {
        return studenti.ToList();
    }

    // Delete
    public bool RimuoviStudente(string matricola)
    {
        var studente = TrovaStudente(matricola);
        if (studente != null)
        {
            // Rimuovi da tutti i corsi
            foreach (var corso in studente.CorsiSeguiti.ToList())
            {
                corso.RimuoviStudente(studente);
            }
            studenti.Remove(studente);
            Console.WriteLine($"Studente {matricola} rimosso!");
            return true;
        }
        Console.WriteLine("Studente non trovato!");
        return false;
    }

    // ========== CRUD CORSI ==========

    // Create
    public void AggiungiCorso(Corso corso)
    {
        if (corso != null && !corsi.Any(c => c.Codice == corso.Codice))
        {
            corsi.Add(corso);
            Console.WriteLine($"Corso '{corso.Nome}' aggiunto!");
        }
        else
        {
            Console.WriteLine("Corso già esistente o dati non validi!");
        }
    }

    // Read
    public Corso? TrovaCorso(string codice)
    {
        return corsi.FirstOrDefault(c => c.Codice == codice);
    }

    // Read all
    public List<Corso> GetTuttiCorsi()
    {
        return corsi.ToList();
    }

    // Delete
    public bool RimuoviCorso(string codice)
    {
        var corso = TrovaCorso(codice);
        if (corso != null)
        {
            // Disiscrivi tutti gli studenti
            foreach (var studente in corso.GetStudentiIscritti().ToList())
            {
                studente.DisiscrivitiDaCorso(corso);
            }
            corsi.Remove(corso);
            Console.WriteLine($"Corso {codice} rimosso!");
            return true;
        }
        Console.WriteLine("Corso non trovato!");
        return false;
    }

    // ========== METODI STATISTICI ==========

    // Top N studenti per media
    public List<Studente> StudentiMigliori(int n)
    {
        return studenti
            .Where(s => s.CorsiSeguiti.Count > 0)
            .OrderByDescending(s => s.MediaVoti)
            .Take(n)
            .ToList();
    }

    // Corsi sottoiscritti (< 50%)
    public List<Corso> CorsiSottoiscritti()
    {
        return corsi.Where(c => c.IsSottoiscritto()).ToList();
    }

    // ========== STAMPE ==========

    public void StampaStatistiche()
    {
        Console.WriteLine("\n╔══════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║              📊 STATISTICHE UNIVERSITÀ                       ║");
        Console.WriteLine("╚══════════════════════════════════════════════════════════════╝");

        Console.WriteLine($"\nTotale Studenti: {studenti.Count}");
        Console.WriteLine($"Totale Corsi: {corsi.Count}");

        // Studenti laureabili
        int laureabili = studenti.Count(s => s.IsLaureabile());
        Console.WriteLine($"Studenti Laureabili: {laureabili}");

        // Media generale
        double mediaGenerale = studenti
            .Where(s => s.CorsiSeguiti.Count > 0)
            .Select(s => s.MediaVoti)
            .DefaultIfEmpty(0)
            .Average();
        Console.WriteLine($"Media Generale Studenti: {mediaGenerale:F2}");

        // CFU medi
        double cfuMedi = studenti.Select(s => s.TotaleCFU()).DefaultIfEmpty(0).Average();
        Console.WriteLine($"CFU Medi per Studente: {cfuMedi:F1}");

        // Corsi pieni
        int corsiPieni = corsi.Count(c => !c.IsDisponibile());
        Console.WriteLine($"Corsi al Completo: {corsiPieni}/{corsi.Count}");

        // Corsi sottoiscritti
        var corsiSott = CorsiSottoiscritti();
        Console.WriteLine($"Corsi Sottoiscritti (<50%): {corsiSott.Count}");

        // Top 3 studenti
        Console.WriteLine("\n--- TOP 3 STUDENTI ---");
        var top3 = StudentiMigliori(3);
        if (top3.Count == 0)
        {
            Console.WriteLine("Nessuno studente con corsi e voti.");
        }
        else
        {
            for (int i = 0; i < top3.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {top3[i].Nome} {top3[i].Cognome} - Media: {top3[i].MediaVoti:F2}");
            }
        }

        // Corsi sottoiscritti
        if (corsiSott.Count > 0)
        {
            Console.WriteLine("\n--- CORSI SOTTOISCRITTI ---");
            foreach (var corso in corsiSott)
            {
                Console.WriteLine($"  {corso.InfoBreve()} - {corso.PercentualeRiempimento:F1}%");
            }
        }

        Console.WriteLine("\n═══════════════════════════════════════════════════════════════\n");
    }

    public void StampaTuttiStudenti()
    {
        Console.WriteLine("\n--- LISTA STUDENTI ---");
        if (studenti.Count == 0)
        {
            Console.WriteLine("Nessuno studente registrato.");
            return;
        }

        foreach (var s in studenti.OrderBy(s => s.Cognome))
        {
            Console.WriteLine(s);
        }
    }

    public void StampaTuttiCorsi()
    {
        Console.WriteLine("\n--- LISTA CORSI ---");
        if (corsi.Count == 0)
        {
            Console.WriteLine("Nessun corso disponibile.");
            return;
        }

        foreach (var c in corsi.OrderBy(c => c.Codice))
        {
            Console.WriteLine(c);
        }
    }
}
