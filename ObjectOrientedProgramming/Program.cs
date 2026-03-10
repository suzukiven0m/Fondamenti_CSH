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

        
        
        Student student1 = new Student();
        AskInfoStudent(student1);
        Console.WriteLine(student1.Info());
        
        
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

        int TotalAge = facundo.Age() + simone.Age() + student1.Age();
        Console.WriteLine(TotalAge);
        
        

    }
    public static void AskInfoStudent(Student student)
    {
           
        Console.WriteLine("Insert the name of the student: ");
        student.Name = Console.ReadLine();
        Console.WriteLine("Insert the surname of the student: ");
        student.Surname = Console.ReadLine();
        Console.WriteLine("When was the student born? ");
        student.YearBorn = int.Parse(Console.ReadLine());
        
        

    }
}
