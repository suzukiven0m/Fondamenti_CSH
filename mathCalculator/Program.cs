namespace mathCalculator;

using System;

class Calcolatrice
{
    static void Main()
    {
        int scelta;
        string storico = "";
        int contatoreCalcoli = 0;

        Console.WriteLine("╔══════════════════════════════╗");
        Console.WriteLine("║     CALCOLATRICE C#          ║");
        Console.WriteLine("╚══════════════════════════════╝");

        do
        {
           
            Console.WriteLine("\n┌─────────────────────────┐");
            Console.WriteLine("│        MENU             │");
            Console.WriteLine("├─────────────────────────┤");
            Console.WriteLine("│  1. Addizione     (+)   │");
            Console.WriteLine("│  2. Sottrazione   (-)   │");
            Console.WriteLine("│  3. Moltiplicazione (*) │");
            Console.WriteLine("│  4. Divisione     (/)   │");
            Console.WriteLine("│  5. Modulo        (%)   │");
            Console.WriteLine("│  0. Esci                │");
            Console.WriteLine("└─────────────────────────┘");
            Console.Write("Scegli operazione: ");
            scelta = int.Parse(Console.ReadLine());

            if (scelta >= 1 && scelta <= 5)
            {
               
                Console.Write("Inserisci il primo numero:  ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Inserisci il secondo numero: ");
                double num2 = double.Parse(Console.ReadLine());

                double risultato = 0;
                string operatore = "";
                bool errore = false;
                
                if (scelta == 1)
                {
                    operatore = "+";
                    risultato = num1 + num2;
                }
                else if (scelta == 2)
                {
                    operatore = "-";
                    risultato = num1 - num2;
                }
                else if (scelta == 3)
                {
                    operatore = "*";
                    risultato = num1 * num2;
                }
                else if (scelta == 4)
                {
                    operatore = "/";
                    if (num2 == 0)
                    {
                        Console.WriteLine("\n⚠️  ERRORE: Divisione per zero non consentita!");
                        errore = true;
                    }
                    else
                    {
                        risultato = num1 / num2;
                    }
                }
                else if (scelta == 5)
                {
                    operatore = "%";
                    if (num2 == 0)
                    {
                        Console.WriteLine("\n⚠️  ERRORE: Modulo per zero non consentito!");
                        errore = true;
                    }
                    else
                    {
                        risultato = num1 % num2;
                    }
                }
                
                if (!errore)
                {
                    string calcolo = num1 + " " + operatore + " " + num2 + " = " + risultato;
                    Console.WriteLine("\n Risultato: " + calcolo);

                    contatoreCalcoli = contatoreCalcoli + 1;
                    
                    if (storico == "")
                        storico = calcolo;
                    else
                        storico = storico + "\n   " + calcolo;
                    
                    Console.WriteLine("\n STORICO CALCOLI:");
                    Console.WriteLine("   " + storico);
                }
            }
            else if (scelta != 0)
            {
                Console.WriteLine("\n Scelta non valida! Scegli un numero tra 0 e 5.");
            }

        } while (scelta != 0);

      
        Console.WriteLine("\n╔══════════════════════════════════╗");
        Console.WriteLine("║         RIEPILOGO FINALE         ║");
        Console.WriteLine("╠══════════════════════════════════╣");
        Console.WriteLine("║  Calcoli eseguiti: " + contatoreCalcoli + "           ".Substring(contatoreCalcoli.ToString().Length) + "   ║");
        Console.WriteLine("╚══════════════════════════════════╝");

        if (contatoreCalcoli == 0)
        {
            Console.WriteLine("Nessun calcolo effettuato.");
        }
        else
        {
            Console.WriteLine("\nTutti i calcoli eseguiti:");
            Console.WriteLine("   " + storico);
        }

        Console.WriteLine("\nArrivederci! ");
    }
}