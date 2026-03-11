namespace ObjectOrientedProgramming;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new();
        AskInfoStudent(student1);
        Console.WriteLine(student1.Info);
        
        Student facundo = new()
        {
            Name = "Facundo",
            Surname = "Fanti",
            YearBorn = 1991
        };

        Console.WriteLine(facundo.Info);
        
        Student simone = new()
        {
            Name = "Simone",
            Surname = "Monito",
            YearBorn = 1990
        };

        Console.WriteLine(simone.Info);

        int totalAge = facundo.Age + simone.Age + student1.Age;
        Console.WriteLine(totalAge);
    }

    public static void AskInfoStudent(Student student)
    {
        Console.WriteLine("Insert the name of the student: ");
        student.Name = Console.ReadLine() ?? "";
        Console.WriteLine("Insert the surname of the student: ");
        student.Surname = Console.ReadLine() ?? "";
        Console.WriteLine("When was the student born? ");
        student.YearBorn = int.Parse(Console.ReadLine() ?? "0");
    }
}
