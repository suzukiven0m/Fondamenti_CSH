namespace OOP_Library;

internal class Libro
{
    // Campi privati
    private string titolo;
    private string autore;
    private string isbn;
    private int annoPubblicazione;
    private bool disponibile;

    // Proprietà
    public string Titolo
    {
        get => titolo;
        set => titolo = value;
    }

    public string Autore
    {
        get => autore;
        set => autore = value;
    }

    public string Isbn
    {
        get => isbn;
        set => isbn = value;
    }

    public int AnnoPubblicazione
    {
        get => annoPubblicazione;
        set => annoPubblicazione = value;
    }

    public bool Disponibile
    {
        get => disponibile;
    }

    // Costruttore
    public Libro(string titolo, string autore, string isbn, int annoPubblicazione)
    {
        this.titolo = titolo;
        this.autore = autore;
        this.isbn = isbn;
        this.annoPubblicazione = annoPubblicazione;
        this.disponibile = true; // Di default il libro è disponibile
    }

    // Metodo Presta
    public bool Presta()
    {
        if (disponibile)
        {
            disponibile = false;
            Console.WriteLine($"Il libro '{titolo}' è stato prestato.");
            return true;
        }
        else
        {
            Console.WriteLine($"Il libro '{titolo}' non è disponibile (già prestato).");
            return false;
        }
    }

    // Metodo Restituisci
    public bool Restituisci()
    {
        if (!disponibile)
        {
            disponibile = true;
            Console.WriteLine($"Il libro '{titolo}' è stato restituito.");
            return true;
        }
        else
        {
            Console.WriteLine($"Il libro '{titolo}' era già disponibile.");
            return false;
        }
    }

    // Override ToString
    public override string ToString()
    {
        string stato = disponibile ? "DISPONIBILE" : "PRESTATO";
        return $"[{isbn}] {titolo} - {autore} ({annoPubblicazione}) [{stato}]";
    }
}
