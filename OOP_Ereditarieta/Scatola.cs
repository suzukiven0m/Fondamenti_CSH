namespace OOP_Ereditarieta;

public class Scatola
{
    public double Lunghezza { get; set; }
    public double Larghezza { get; set; }
    public double Altezza { get; set; }

    public virtual string Info() =>
        $"La scatola ha Lunghezza: {Lunghezza} Larghezza: {Larghezza} e Altezza: {Altezza} e volume {Volume()}";

    public double Volume() => Lunghezza * Larghezza * Altezza;
}