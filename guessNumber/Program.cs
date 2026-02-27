using System;

namespace guessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
--                                                       _               
--      __ _ _   _  ___  ___ ___   _ __  _   _ _ __ ___ | |__   ___ _ __ 
--     / _` | | | |/ _ \/ __/ __| | '_ \| | | | '_ ` _ \| '_ \ / _ \ '__|
--    | (_| | |_| |  __/\__ \__ \ | | | | |_| | | | | | | |_) |  __/ |   
--     \__, |\__,_|\___||___/___/ |_| |_|\__,_|_| |_| |_|_.__/ \___|_|   
--     |___/  
        You have to guess the number!
        Ps. You only have seven tries!
");

            int number = 69;       
            int maxTries = 7;
            int tries = 0;

            while (tries < maxTries)
            {
                Console.Write("Please insert a number: ");
                int input = int.Parse(Console.ReadLine());
                tries++;
                
                if (input > number)
                {
                    Console.WriteLine("Your number is too high!");
                }
                else if (input < number)
                {
                    Console.WriteLine("Your number is too low!");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed it in {tries} {(tries == 1 ? "try" : "tries")}!");
                    break; 
                }

                int triesLeft = maxTries - tries;
                if (triesLeft > 0)
                {
                    Console.WriteLine($"You have {triesLeft} {(triesLeft == 1 ? "try" : "tries")} left.");
                }
                else
                {
                    Console.WriteLine($"Game over! The correct number was {number}.");
                }
            }
        }
    }
}