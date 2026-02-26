using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace Bank_System
{
    internal class Program
    //        Simula un conto bancario semplice.Il programma deve: 1. Chiedere il nome del titolare e il
    //saldo iniziale 2. Chiedere un importo da depositare 3. Chiedere un importo da prelevare 4.
    //Controllare che il prelievo non superi il saldo disponibile(usa bool salienteOk) 5. Stampare
    //un riepilogo finale con: nome titolare, saldo iniziale, deposito effettuato, prelievo effettuato
    //(o rifiutato), saldo finale.FORMATO OUTPUT: ogni valore monetario deve essere
    //visualizzato con 2 decimali e il simbolo €.




    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome back... Please insert your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, how much is your balance? ");
            int balance = int.Parse(Console.ReadLine());
            Console.WriteLine("How much will you deposit today? ");
            int deposit = int.Parse(Console.ReadLine());
            Console.WriteLine("How much money will you withdraw today?");
            int withdraw = int.Parse(Console.ReadLine());
            int new_balance = balance + deposit;
            bool withdrawOK = (balance + deposit) > withdraw;
            var BalanceDecimal = new_balance.ToString("F2");
            var WithdrawDecimal = withdraw.ToString("F2");
            var DepositDecimal = deposit.ToString("F2");
            int finalbalance = (balance + deposit) - withdraw;
            var finalDecimal = finalbalance.ToString("F2");
            if (withdrawOK)
            {
                Console.WriteLine($"{name}, your balance is € {BalanceDecimal}, you just deposited € {DepositDecimal}, and € withdrawn {WithdrawDecimal}, your remaining balance is {finalDecimal}");
            }
            else
            {
                Console.WriteLine("Your balance is too low ");
            }
        }
    }
}
