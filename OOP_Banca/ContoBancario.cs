namespace OOP_Banca;

internal class ContoBancario
{
   
    private string intestatario;
    private double saldo;
    private string numeroConto;

   
    public string Intestatario
    {
        get => intestatario;
        set => intestatario = value;
    }

    public double Saldo => saldo;

    public string NumeroConto
    {
        get => numeroConto;
        set => numeroConto = value;
    }

   
    public ContoBancario(string intestatario, double saldoIniziale)
    {
        this.intestatario = intestatario;
        this.saldo = saldoIniziale >= 0 ? saldoIniziale : 0;
        this.numeroConto = GeneraNumeroConto();
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
            saldo += importo;
            Console.WriteLine($"Deposito di {importo:F2} euro effettuato. Nuovo saldo: {saldo:F2} euro");
        }
        else
        {
            Console.WriteLine("Importo non valido per il deposito.");
        }
    }

    
    public bool Preleva(double importo)
    {
        if (importo > 0 && saldo >= importo)
        {
            saldo -= importo;
            Console.WriteLine($"Prelievo di {importo:F2} euro effettuato. Nuovo saldo: {saldo:F2} euro");
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

        if (saldo < importo)
        {
            Console.WriteLine("Saldo insufficiente per il trasferimento.");
            return false;
        }

        
        saldo -= importo;
        destinatario.saldo += importo;

        Console.WriteLine($"Trasferimento di {importo:F2} euro da {intestatario} a {destinatario.intestatario} effettuato.");
        Console.WriteLine($"  Nuovo saldo {intestatario}: {saldo:F2} euro");
        Console.WriteLine($"  Nuovo saldo {destinatario.intestatario}: {destinatario.saldo:F2} euro");

        return true;
    }

    
    public override string ToString()
    {
        return $"Conto [{numeroConto}] - {intestatario}: {saldo:F2} euro";
    }
}
