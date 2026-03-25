namespace OOP_Bravi;

internal class Studente
{
    public string Nome { get; set; } = "";
    public string Cognome { get; set; } = "";
    public int AnnoDiNascita { get; set; }
    public string Valutazione { get; set; } = "";

    public Studente() { }

    public Studente(string nome, string cognome, int annoDiNascita, string valutazione)
    {
        Nome = nome;
        Cognome = cognome;
        AnnoDiNascita = annoDiNascita;
        Valutazione = valutazione;
    }
}
