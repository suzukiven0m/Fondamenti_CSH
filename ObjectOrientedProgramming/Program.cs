namespace ObjectOrientedProgramming;

public class Student
{
    public string Name;
    public string Surname;
    public int Age;
    public double MediumVotes;

    public void PresentYourself()
    {
        Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}");
    }
}