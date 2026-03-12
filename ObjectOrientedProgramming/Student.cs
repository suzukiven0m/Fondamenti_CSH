using System.Runtime.CompilerServices;

namespace ObjectOrientedProgramming;
using System.Linq;
using System;

internal class Student
{
    public string Name { get; set; } = "";
    public string Surname { get; set; } = "";
    public int YearBorn { get; set; }

    public string Info => $" The student is called {Name}, {Surname}." +
                          $" He was born in {YearBorn}. He is now {Age} years old. ";

    public int Age => DateTime.Now.Year - YearBorn;


    public Student(string name, string surname, int yearBorn)
    {
        this.Name = name;
        this.Surname = surname;
        this.YearBorn = YearBorn;
    }
}
