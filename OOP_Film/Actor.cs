namespace OOP_Film;

internal class Actor
{
    public string Name;
    public string Surname;

    public string Info()
    {
        return $"The principal character was reprised by: {Name}, {Surname}";
    }

}