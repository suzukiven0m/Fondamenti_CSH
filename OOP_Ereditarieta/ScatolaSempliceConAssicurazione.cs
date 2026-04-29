namespace OOP_Ereditarieta;

public class ScatolaSempliceConAssicurazione : Scatola

{
    private string _nomeAssicurazione;
    private double _valoreAssicurato;
    private double _premioAssicurazione;
    
    public string NomeAssicurazione { get; set; }
    public double ValoreAssicurato { get; set; }
    public double PremioAssicurazione { get; set; }

    public ScatolaSempliceConAssicurazione()
    {
        NomeAssicurazione = string.Empty;
        ValoreAssicurato = 0;
        PremioAssicurazione = 0;
    }

    public ScatolaSempliceConAssicurazione(double altezza, double larghezza, double lunghezza, string nomeAssicurazione,
        double valoreAssicurato, double premioAssicurazione)
    {
        Altezza = altezza;
        Larghezza = larghezza;
        Lunghezza = lunghezza;
        NomeAssicurazione = nomeAssicurazione;
        ValoreAssicurato = valoreAssicurato;
        PremioAssicurazione = premioAssicurazione;
    }

    public override string Info() =>
        $"{base.Info()} ed ha un'assicurazione {NomeAssicurazione}, valore {ValoreAssicurato}, premio {PremioAssicurazione}";
}