namespace OOP_Film;

internal class Nation
{
    public string Name { get; set; } = "";
    

    public string Info => $"It was made in the country of {Name}";

    public Nation(string name)
    {
        this.Name = name;
    }
    public Nation(){}
}