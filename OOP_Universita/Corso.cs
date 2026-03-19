namespace OOP_Universita;

internal class Corso
{
    // Proprietà
    public string Codice { get; set; } = "";
    public string Nome { get; set; } = "";
    public int Crediti { get; set; }
    public string Professore { get; set; } = "";
    public int MaxStudenti { get; set; }

    // Lista studenti iscritti con i loro voti
    private Dictionary<Studente, int> studentiIscritti;

    // Costruttore
    public Corso(string codice, string nome, int crediti, string professore, int maxStudenti)
    {
        Codice = codice;
        Nome = nome;
        Crediti = crediti;
        Professore = professore;
        MaxStudenti = maxStudenti;
        studentiIscritti = new Dictionary<Studente, int>();
    }

    // Proprietà: numero di iscritti attuali
    public int NumeroIscritti => studentiIscritti.Count;

    // Proprietà: percentuale riempimento
    public double PercentualeRiempimento => (double)NumeroIscritti / MaxStudenti * 100;

    // Iscrivi uno studente
    public bool IscriviStudente(Studente studente, int votoIniziale = 0)
    {
        if (studente == null) return false;
        if (studentiIscritti.ContainsKey(studente)) return false;
        if (!IsDisponibile()) return false;

        studentiIscritti[studente] = votoIniziale;
        return true;
    }

    // Rimuovi uno studente
    public bool RimuoviStudente(Studente studente)
    {
        if (studente == null) return false;
        return studentiIscritti.Remove(studente);
    }

    // Verifica disponibilità
    public bool IsDisponibile()
    {
        return NumeroIscritti < MaxStudenti;
    }

    // Assegna voto a uno studente
    public bool AssegnaVoto(Studente studente, int voto)
    {
        if (!studentiIscritti.ContainsKey(studente)) return false;
        if (voto < 0 || voto > 30) return false;

        studentiIscritti[studente] = voto;
        return true;
    }

    // Ottieni voto di uno studente
    public int GetVotoStudente(Studente studente)
    {
        if (studentiIscritti.TryGetValue(studente, out int voto))
        {
            return voto;
        }
        return 0;
    }

    // Calcola media del corso
    public double MediaCorso()
    {
        if (studentiIscritti.Count == 0) return 0;
        return studentiIscritti.Values.Average();
    }

    // Ottieni lista studenti iscritti
    public List<Studente> GetStudentiIscritti()
    {
        return studentiIscritti.Keys.ToList();
    }

    // Verifica se sottoiscritto (meno del 50%)
    public bool IsSottoiscritto()
    {
        return PercentualeRiempimento < 50;
    }

    // Override ToString
    public override string ToString()
    {
        string disponibilita = IsDisponibile() ? "DISPONIBILE" : "COMPLETO";
        return $"[{Codice}] {Nome} ({Crediti} CFU) - Prof. {Professore} | {NumeroIscritti}/{MaxStudenti} iscritti ({PercentualeRiempimento:F1}%) [{disponibilita}] | Media: {MediaCorso():F2}";
    }

    // Info breve
    public string InfoBreve()
    {
        return $"[{Codice}] {Nome} ({Crediti} CFU)";
    }
}
