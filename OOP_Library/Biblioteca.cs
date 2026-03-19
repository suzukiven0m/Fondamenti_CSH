namespace OOP_Library;

internal class Biblioteca
{
    // Campo privato
    private List<Libro> catalogo;

    // Costruttore
    public Biblioteca()
    {
        catalogo = new List<Libro>();
    }

    // Aggiungi libro al catalogo
    public void AggiungiLibro(Libro libro)
    {
        if (libro != null)
        {
            catalogo.Add(libro);
            Console.WriteLine($"Libro '{libro.Titolo}' aggiunto al catalogo.");
        }
    }

    // Cerca per titolo (case-insensitive, cerca parziale)
    public List<Libro> CercaPerTitolo(string titolo)
    {
        return catalogo
            .Where(l => l.Titolo.Contains(titolo, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    // Cerca per autore (case-insensitive, cerca parziale)
    public List<Libro> CercaPerAutore(string autore)
    {
        return catalogo
            .Where(l => l.Autore.Contains(autore, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    // Restituisce i libri disponibili
    public List<Libro> LibriDisponibili()
    {
        return catalogo.Where(l => l.Disponibile).ToList();
    }

    // Restituisce i libri prestati
    public List<Libro> LibriPrestati()
    {
        return catalogo.Where(l => !l.Disponibile).ToList();
    }

    // Stampa statistiche della biblioteca
    public void StampaStatistiche()
    {
        Console.WriteLine("\n=== STATISTICHE BIBLIOTECA ===");
        Console.WriteLine($"Totale libri in catalogo: {catalogo.Count}");
        Console.WriteLine($"Libri disponibili: {LibriDisponibili().Count}");
        Console.WriteLine($"Libri prestati: {LibriPrestati().Count}");

        if (catalogo.Count > 0)
        {
            double percentualePrestati = (double)LibriPrestati().Count / catalogo.Count * 100;
            Console.WriteLine($"Percentuale libri prestati: {percentualePrestati:F1}%");
        }

        // Autori presenti
        var autori = catalogo.Select(l => l.Autore).Distinct().OrderBy(a => a);
        Console.WriteLine($"\nAutori presenti ({autori.Count()}):");
        foreach (var autore in autori)
        {
            int count = catalogo.Count(l => l.Autore == autore);
            Console.WriteLine($"  - {autore} ({count} libro/i)");
        }

        Console.WriteLine("==============================\n");
    }

    // Stampa tutto il catalogo
    public void StampaCatalogo()
    {
        Console.WriteLine("\n--- CATALOGO COMPLETO ---");
        foreach (var libro in catalogo)
        {
            Console.WriteLine(libro);
        }
        Console.WriteLine("-------------------------\n");
    }
}
