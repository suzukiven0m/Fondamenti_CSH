namespace OOP_Banca;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SIMULAZIONE OPERAZIONI BANCARIE ===\n");

        // Creazione di due conti bancari
        ContoBancario conto1 = new ContoBancario("Alice Rossi", 1000.00);
        ContoBancario conto2 = new ContoBancario("Marco Bianchi", 500.00);

        // Stampa stato iniziale
        Console.WriteLine("--- Stato Iniziale ---");
        Console.WriteLine(conto1);
        Console.WriteLine(conto2);
        Console.WriteLine();

        // Test: Deposito
        Console.WriteLine("--- Deposito ---");
        conto1.Deposita(500.00);
        conto2.Deposita(-100.00); // Test importo negativo
        Console.WriteLine();

        // Test: Prelievo
        Console.WriteLine("--- Prelievo ---");
        conto1.Preleva(200.00);
        conto2.Preleva(1000.00); // Test saldo insufficiente
        Console.WriteLine();

        // Test: Trasferimento
        Console.WriteLine("--- Trasferimento ---");
        conto1.Trasferisci(conto2, 300.00);
        conto1.Trasferisci(conto2, 5000.00); // Test saldo insufficiente
        Console.WriteLine();

        // Stato finale
        Console.WriteLine("--- Stato Finale ---");
        Console.WriteLine(conto1);
        Console.WriteLine(conto2);
    }
}
