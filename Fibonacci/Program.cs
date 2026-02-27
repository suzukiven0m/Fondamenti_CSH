namespace Fibonacci;
// Mostra un menu (do-while) con tre opzioni:
// 1) Calcola il fattoriale di N  (es: 5! = 120)
// 2) Stampa i primi N numeri di Fibonacci  (0, 1, 1, 2, 3, 5, 8...)  0) Esci Dopo ogni calcolo, il menu si ripresenta finché l'utente non sceglie
// 0. Gestisci il caso N=0: 0! = 1, Fibonacci(0) = solo il numero 0.
class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine(@"
                                               
        ,--.   ,--.,------.,--.  ,--.,--. ,--. 
        |   `.'   ||  .---'|  ,'.|  ||  | |  | 
        |  |'.'|  ||  `--, |  |' '  ||  | |  | 
        |  |   |  ||  `---.|  | `   |'  '-'  ' 
        `--'   `--'`------'`--'  `--' `-----'  
        1. Calculate factorial of N.
        2. Print N fibonacci numbers.
        0. Quit.");  
        } while (Console.ReadKey().Key != ConsoleKey.NumPad0);
        
        
        
    }
    
}