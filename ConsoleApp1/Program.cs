using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calls the greeting function, like in python 
            //Greeting();   
            //TellAge();
            //Print();
            GuessNumber();

        }

        static void GuessNumber()
        {
            int guess = 10;
            int number;
            int tries = 0;  //Counter Variable

            Console.WriteLine("Insert a number from 1 to 98, 99 to quit: ");
            number = int.Parse(Console.ReadLine());

            while (number != 99)
            {
                tries++;  

                if (number == guess)
                {
                    Console.Clear();
                    Console.WriteLine("You got the number right!");
                    Console.WriteLine("Number of tries: " + tries);
                    break;
                    
                }
                else if (number > guess)
                {
                    Console.WriteLine("Number too high!");
                }
                else
                {
                    Console.WriteLine("Number too low!");
                }

                Console.WriteLine("Insert a number from 1 to 98, 99 to quit: ");
                number = int.Parse(Console.ReadLine());
            }
            if (number == 99)
            {
                Console.Clear();
                Console.WriteLine("Game over!");
                Console.WriteLine($" You tried {tries - 1} times!");
            }
            
        }









        static void Print()
            {
                Console.WriteLine("Insert a number, i will print every number that is pair of two");
                int number = int.Parse(Console.ReadLine());
                for (int i = 2; i < number; i++)
                {
                    if (i % 2 == 0)
                    {
                        //Console.WriteLine(i);
                        Console.Write($"{i}\t");
                    }




                }











                static void TellAge()
                {
                    Console.WriteLine("Insert your age: ");
                    int age = int.Parse(Console.ReadLine());
                    if (age < 18)
                    {
                        Console.WriteLine("You are underage");
                    }
                    else if (age >= 18 && age <= 40)
                    {
                        Console.WriteLine("You are an adult!");
                    }
                    else
                    {
                        Console.WriteLine("You are old!");
                    }





                }

                static void Greeting()
                {
                    //Input name and surname and Greets you personally
                    Console.WriteLine("Insert your name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Insert your surname: ");
                    string surname = Console.ReadLine();
                    Console.WriteLine($" Welcome {name} {surname} !");

                }
            }
        }
    }

    