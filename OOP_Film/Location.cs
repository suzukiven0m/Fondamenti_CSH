namespace OOP_Film;

internal class Location
{
    public string Name { get; set; }


    public string Info => $"It was filmed specifically in {Name}";

    public Location(string name)
    {
        this.Name = name;
    }
    
    
}