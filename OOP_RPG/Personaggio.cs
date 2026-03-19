namespace OOP_RPG;

internal class Personaggio
{
    // Campi privati
    private string nome;
    private string classe;
    private int hp;
    private int hpMax;
    private int attacco;
    private int difesa;
    private int livello;

    // Proprietà
    public string Nome => nome;
    public string Classe => classe;
    public int HP => hp;
    public int HPMax => hpMax;
    public bool IsVivo => hp > 0;
    public int Livello => livello;

    // Costruttore che inizializza in base al tipo
    public Personaggio(string nome, string classe)
    {
        this.nome = nome;
        this.classe = classe;
        this.livello = 1;

        // Inizializzazione basata sulla classe
        switch (classe.ToLower())
        {
            case "guerriero":
                hpMax = 120;
                hp = 120;
                attacco = 25;
                difesa = 15;
                break;
            case "mago":
                hpMax = 80;
                hp = 80;
                attacco = 40;
                difesa = 5;
                break;
            case "ladro":
                hpMax = 90;
                hp = 90;
                attacco = 30;
                difesa = 10;
                break;
            case "chierico":
                hpMax = 100;
                hp = 100;
                attacco = 20;
                difesa = 12;
                break;
            default: // Default/Precettore
                hpMax = 100;
                hp = 100;
                attacco = 20;
                difesa = 10;
                break;
        }
    }

    // Metodo Attacca
    public int Attacca(Personaggio bersaglio)
    {
        if (!IsVivo)
        {
            return 0;
        }

        // Danno base con variazione casuale (80% - 120% dell'attacco)
        Random random = new Random();
        double variazione = random.Next(80, 121) / 100.0;
        int danno = (int)(attacco * variazione);

        // Critico (10% di probabilità)
        bool critico = random.Next(1, 101) <= 10;
        if (critico)
        {
            danno = (int)(danno * 1.5);
            Console.WriteLine($"  *** COLPO CRITICO! ***");
        }

        int dannoInflitto = bersaglio.RiceviDanno(danno);
        return dannoInflitto;
    }

    // Metodo RiceviDanno
    public int RiceviDanno(int danno)
    {
        // Calcola danno netto considerando la difesa
        int dannoNetto = danno - difesa;
        if (dannoNetto < 1)
        {
            dannoNetto = 1; // Danno minimo
        }

        hp -= dannoNetto;
        if (hp < 0)
        {
            hp = 0;
        }

        return dannoNetto;
    }

    // Metodo Cura
    public void Cura(int quantita)
    {
        if (quantita <= 0)
        {
            return;
        }

        hp += quantita;
        if (hp > hpMax)
        {
            hp = hpMax;
        }

        Console.WriteLine($"  {nome} si è curato di {quantita} HP!");
    }

    // Metodo SaliDiLivello
    public void SaliDiLivello()
    {
        livello++;
        hpMax += 10;
        attacco += 5;
        difesa += 3;
        hp = hpMax; // Ripristina HP al massimo

        Console.WriteLine($"  {nome} è salito al livello {livello}!");
        Console.WriteLine($"    HP Max: {hpMax}, Attacco: {attacco}, Difesa: {difesa}");
    }

    // Override ToString con barra HP visiva
    public override string ToString()
    {
        int barraLunghezza = 10;
        int hpPieni = (int)((double)hp / hpMax * barraLunghezza);
        int hpVuoti = barraLunghezza - hpPieni;

        string barra = new string('#', hpPieni) + new string('.', hpVuoti);
        return $"{nome} [{classe} Lv.{livello}] [{barra}] {hp}/{hpMax} HP";
    }

    // Metodo per mostrare lo stato breve
    public string StatoBreve()
    {
        return $"{nome} [{classe}] {hp}/{hpMax} HP";
    }
}
