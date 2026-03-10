namespace ObjectOrientedProgramming;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // declare a variable 
        int hourStart;
        hourStart = 14;
        // declare a string variable
        string hourPreferred;
        hourPreferred = "Break";

        
        
        // declare a variable student type
        Student facundo;
        // assign a value 
        facundo = new Student();
        facundo.Name = "Facundo";
        facundo.Surname = "Fanti";
        facundo.YearBorn = 1991;
        
        Console.WriteLine(facundo.Info());
        
        Student simone;
        simone = new Student();
        simone.Name = "Simone";
        simone.Surname = "Monito";
        simone.YearBorn = 1990;
        
        Console.WriteLine(simone.Info());

        int TotalAge = facundo.Age() + simone.Age();
        Console.WriteLine(TotalAge);

    }
}