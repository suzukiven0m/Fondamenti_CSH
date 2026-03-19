namespace OOP_Universita;

internal class Studente
{
    // Proprietà base
    public string Nome { get; set; } = "";
    public string Cognome { get; set; } = "";
    public int AnnoNascita { get; set; }
    public string Matricola { get; set; } = "";

    // Lista corsi seguiti
    public List<Corso> CorsiSeguiti { get; private set; }

    // Costruttore
    public Studente(string nome, string cognome, int annoNascita, string matricola)
    {
        Nome = nome;
        Cognome = cognome;
        AnnoNascita = annoNascita;
        Matricola = matricola;
        CorsiSeguiti = new List<Corso>();
    }

    // Proprietà calcolata: Età
    public int Eta => DateTime.Now.Year - AnnoNascita;

    // Proprietà calcolata: Media voti
    public double MediaVoti
    {
        get
        {
            if (CorsiSeguiti.Count == 0) return 0;
            return CorsiSeguiti.Average(c => c.GetVotoStudente(this));
        }
    }

    // Iscriviti a un corso
    public bool IscrivitiACorso(Corso corso)
    {
        if (corso == null) return false;

        // Controlla se già iscritto
        if (CorsiSeguiti.Any(c => c.Codice == corso.Codice))
        {
            Console.WriteLine("Sei già iscritto a questo corso!");
            return false;
        }

        // Controlla se il corso ha posti disponibili
        if (!corso.IsDisponibile())
        {
            Console.WriteLine("Il corso è al completo!");
            return false;
        }

        // Procedi con l'iscrizione
        if (corso.IscriviStudente(this))
        {
            CorsiSeguiti.Add(corso);
            Console.WriteLine($"Iscrizione a '{corso.Nome}' avvenuta con successo!");
            return true;
        }

        return false;
    }

    // Disiscriviti da un corso
    public bool DisiscrivitiDaCorso(Corso corso)
    {
        if (corso == null) return false;

        if (CorsiSeguiti.Remove(corso))
        {
            corso.RimuoviStudente(this);
            Console.WriteLine($"Disiscritto dal corso '{corso.Nome}'");
            return true;
        }

        return false;
    }

    // Calcola totale CFU
    public int TotaleCFU()
    {
        return CorsiSeguiti.Sum(c => c.Crediti);
    }

    // Verifica se laureabile
    public bool IsLaureabile()
    {
        return TotaleCFU() >= 180 && MediaVoti >= 18;
    }

    // Info studente
    public string Info => $"{Matricola} - {Nome} {Cognome} ({Eta} anni)";

    // Override ToString
    public override string ToString()
    {
        return $"{Matricola} | {Nome} {Cognome} | CFU: {TotaleCFU()} | Media: {MediaVoti:F2} | Laureabile: {(IsLaureabile() ? "SI" : "NO")}";
    }
}
