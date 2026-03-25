namespace OOP_Banca;

internal class ContoBancario
{
   
    private string _intestatario;
    private double _saldo;
    private string _numeroConto;

   
    public string Intestatario
    {
        get => _intestatario;
        set => _intestatario = value;
    }

    public double Saldo => _saldo;

    public string NumeroConto
    {
        get => _numeroConto;
        set => _numeroConto = value;
    }

   
    public ContoBancario(string intestatario, double saldoIniziale)
    {
        this._intestatario = intestatario;
        this._saldo = saldoIniziale >= 0 ? saldoIniziale : 0;
        this._numeroConto = GeneraNumeroConto();
    }

    
    private string GeneraNumeroConto()
    {
        Random random = new Random();
        return $"IT{random.Next(100, 999):D3}";
    }

   
    public void Deposita(double importo)
    {
        if (importo > 0)
        {
            _saldo += importo;
            Console.WriteLine($"Deposito di {importo:F2} euro effettuato. Nuovo saldo: {_saldo:F2} euro");
        }
        else
        {
            Console.WriteLine("Importo non valido per il deposito.");
        }
    }

    
    public bool Preleva(double importo)
    {
        if (importo > 0 && _saldo >= importo)
        {
            _saldo -= importo;
            Console.WriteLine($"Prelievo di {importo:F2} euro effettuato. Nuovo saldo: {_saldo:F2} euro");
            return true;
        }
        else if (importo <= 0)
        {
            Console.WriteLine("Importo non valido per il prelievo.");
            return false;
        }
        else
        {
            Console.WriteLine("Saldo insufficiente per il prelievo.");
            return false;
        }
    }

  
    public bool Trasferisci(ContoBancario destinatario, double importo)
    {
        if (destinatario == null)
        {
            Console.WriteLine("Conto destinatario non valido.");
            return false;
        }

        if (importo <= 0)
        {
            Console.WriteLine("Importo non valido per il trasferimento.");
            return false;
        }

        if (_saldo < importo)
        {
            Console.WriteLine("Saldo insufficiente per il trasferimento.");
            return false;
        }

        
        _saldo -= importo;
        destinatario._saldo += importo;

        Console.WriteLine($"Trasferimento di {importo:F2} euro da {_intestatario} a {destinatario._intestatario} effettuato.");
        Console.WriteLine($"  Nuovo saldo {_intestatario}: {_saldo:F2} euro");
        Console.WriteLine($"  Nuovo saldo {destinatario._intestatario}: {destinatario._saldo:F2} euro");

        return true;
    }

    
    public override string ToString()
    {
        return $"Conto [{_numeroConto}] - {_intestatario}: {_saldo:F2} euro";
    }
}
