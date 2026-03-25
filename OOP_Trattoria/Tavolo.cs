namespace OOP_Trattoria;

public class Tavolo
{
    private List<Pietanza> _pietanze;
    public int NumeroTavolo { get; }

    public Tavolo(int numeroTavolo)
    {
        NumeroTavolo = numeroTavolo;
        _pietanze = new List<Pietanza>();
    }

    public void AggiungiPietanza(Pietanza p)
    {
        _pietanze.Add(p);
    }

    public double CalcolaConto()
    {
        return _pietanze.Sum(p => p.Costo);
    }

    public void StampaDettagli()
    {
        Console.WriteLine($"--- Tavolo {NumeroTavolo} ---");
        foreach (var p in _pietanze)
        {
            Console.WriteLine($"- {p.Nome} ({p.Tipo}): €{p.Costo:F2}");
        }
        Console.WriteLine($"TOTALE: €{CalcolaConto():F2}");
        Console.WriteLine();
    }
}
