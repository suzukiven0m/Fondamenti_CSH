namespace OOP_Ereditarieta;

public class ScatoleSempliceConSpedizione : Scatola
{
    public double CostoSpedizione { get; set; }
    public string Corriere { get; set; }
    public string Indirizzo { get; set; }

    public ScatoleSempliceConSpedizione()
    {
        Corriere = string.Empty;
        Indirizzo = string.Empty;
    }

    public ScatoleSempliceConSpedizione(double altezza, double larghezza, double lunghezza, string corriere,
        string indirizzo, double costoSpedizione) : base()
    {
        Altezza = altezza;
        Larghezza = larghezza;
        Lunghezza = lunghezza;
        Corriere = corriere;
        Indirizzo = indirizzo;
        CostoSpedizione = costoSpedizione;
    }

    public override string Info() =>
        $"{base.Info()} ed ha una spedizione con corriere {Corriere}, costa {CostoSpedizione} al indirizzo {Indirizzo}";
}