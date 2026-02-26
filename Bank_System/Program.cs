using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace Bank_System
{
    internal class Program



    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Welcome back... Please insert your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, how much is your balance? ");
            int balance = int.Parse(Console.ReadLine());
            Console.WriteLine("How much will you deposit today? ");
            int deposit = int.Parse(Console.ReadLine());
            Console.WriteLine("How much money will you withdraw today?");
            int withdraw = int.Parse(Console.ReadLine());
            int newBalance = balance + deposit;
            bool withdrawOk = (balance + deposit) >= withdraw;
            var balanceDecimal = newBalance.ToString("F2");
            var withdrawDecimal = withdraw.ToString("F2");
            var depositDecimal = deposit.ToString("F2");
            int finalbalance = (balance + deposit) - withdraw;
            var finalDecimal = finalbalance.ToString("F2");
            if (withdrawOk)
            {
                Console.Clear();
                Console.WriteLine($"{name}, your balance is € {balanceDecimal}.\n You just deposited € {depositDecimal}.\n Withdrawn € {withdrawDecimal}.\n Your remaining balance is € {finalDecimal} \n");
            }
            else
            {
                Console.WriteLine("Your balance is too low ");
            }
        }
    }
}
