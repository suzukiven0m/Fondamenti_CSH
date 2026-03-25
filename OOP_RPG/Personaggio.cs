namespace OOP_RPG;

internal class Personaggio
{
    // Campi privati
    private string _nome;
    private string _classe;
    private int _hp;
    private int _hpMax;
    private int _attacco;
    private int _difesa;
    private int _livello;

    // Proprietà
    public string Nome => _nome;
    public string Classe => _classe;
    public int HP => _hp;
    public int HPMax => _hpMax;
    public bool IsVivo => _hp > 0;
    public int Livello => _livello;

    // Costruttore che inizializza in base al tipo
    public Personaggio(string nome, string classe)
    {
        this._nome = nome;
        this._classe = classe;
        this._livello = 1;

        // Inizializzazione basata sulla classe
        switch (classe.ToLower())
        {
            case "guerriero":
                _hpMax = 120;
                _hp = 120;
                _attacco = 25;
                _difesa = 15;
                break;
            case "mago":
                _hpMax = 80;
                _hp = 80;
                _attacco = 40;
                _difesa = 5;
                break;
            case "ladro":
                _hpMax = 90;
                _hp = 90;
                _attacco = 30;
                _difesa = 10;
                break;
            case "chierico":
                _hpMax = 100;
                _hp = 100;
                _attacco = 20;
                _difesa = 12;
                break;
            default: // Default/Precettore
                _hpMax = 100;
                _hp = 100;
                _attacco = 20;
                _difesa = 10;
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
        int danno = (int)(_attacco * variazione);

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
        int dannoNetto = danno - _difesa;
        if (dannoNetto < 1)
        {
            dannoNetto = 1; // Danno minimo
        }

        _hp -= dannoNetto;
        if (_hp < 0)
        {
            _hp = 0;
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

        _hp += quantita;
        if (_hp > _hpMax)
        {
            _hp = _hpMax;
        }

        Console.WriteLine($"  {_nome} si è curato di {quantita} HP!");
    }

    // Metodo SaliDiLivello
    public void SaliDiLivello()
    {
        _livello++;
        _hpMax += 10;
        _attacco += 5;
        _difesa += 3;
        _hp = _hpMax; // Ripristina HP al massimo

        Console.WriteLine($"  {_nome} è salito al livello {_livello}!");
        Console.WriteLine($"    HP Max: {_hpMax}, Attacco: {_attacco}, Difesa: {_difesa}");
    }

    // Override ToString con barra HP visiva
    public override string ToString()
    {
        int barraLunghezza = 10;
        int hpPieni = (int)((double)_hp / _hpMax * barraLunghezza);
        int hpVuoti = barraLunghezza - hpPieni;

        string barra = new string('#', hpPieni) + new string('.', hpVuoti);
        return $"{_nome} [{_classe} Lv.{_livello}] [{barra}] {_hp}/{_hpMax} HP";
    }

    // Metodo per mostrare lo stato breve
    public string StatoBreve()
    {
        return $"{_nome} [{_classe}] {_hp}/{_hpMax} HP";
    }
}
