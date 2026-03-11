namespace OOP_Film;

internal class Actor
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string CityBorn { get; set; } 
    public int YearBorn { get; set; }

    public bool IsAlive => YearBorn >= 1900;

    public string Info => $"The actor is called {Name}, {Surname}. He was born in {CityBorn} {(IsAlive ? "and is alive" : "he passed away.")}";

    
    public Actor(){}
}
