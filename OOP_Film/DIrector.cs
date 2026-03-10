namespace OOP_Film;

internal class Director
{
    public string Name;
    public string Surname;
    public int YearBorn;
    public string Country;

    public string Info()
    {
        return $"The film was made by {Name} {Surname}, he was born in {YearBorn} at {Country}.";
    }
    



}