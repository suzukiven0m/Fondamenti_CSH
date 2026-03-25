namespace OOP_Library;

internal class Libro
{
    // Campi privati
    private string _titolo;
    private string _autore;
    private string _isbn;
    private int _annoPubblicazione;
    private bool _disponibile;

    // Proprietà
    public string Titolo
    {
        get => _titolo;
        set => _titolo = value;
    }

    public string Autore
    {
        get => _autore;
        set => _autore = value;
    }

    public string Isbn
    {
        get => _isbn;
        set => _isbn = value;
    }

    public int AnnoPubblicazione
    {
        get => _annoPubblicazione;
        set => _annoPubblicazione = value;
    }

    public bool Disponibile
    {
        get => _disponibile;
    }

    // Costruttore
    public Libro(string titolo, string autore, string isbn, int annoPubblicazione)
    {
        this._titolo = titolo;
        this._autore = autore;
        this._isbn = isbn;
        this._annoPubblicazione = annoPubblicazione;
        this._disponibile = true; // Di default il libro è disponibile
    }

    // Metodo Presta
    public bool Presta()
    {
        if (_disponibile)
        {
            _disponibile = false;
            Console.WriteLine($"Il libro '{_titolo}' è stato prestato.");
            return true;
        }
        else
        {
            Console.WriteLine($"Il libro '{_titolo}' non è disponibile (già prestato).");
            return false;
        }
    }

    // Metodo Restituisci
    public bool Restituisci()
    {
        if (!_disponibile)
        {
            _disponibile = true;
            Console.WriteLine($"Il libro '{_titolo}' è stato restituito.");
            return true;
        }
        else
        {
            Console.WriteLine($"Il libro '{_titolo}' era già disponibile.");
            return false;
        }
    }

    // Override ToString
    public override string ToString()
    {
        string stato = _disponibile ? "DISPONIBILE" : "PRESTATO";
        return $"[{_isbn}] {_titolo} - {_autore} ({_annoPubblicazione}) [{stato}]";
    }
}
