namespace OOP_Film;

internal class Director
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int YearBorn { 
        
        get 
        
        
        
        ; set; }
    public string Country { get; set; }

    public bool IsAlive => YearBorn >= 1900;

    public string Info => $"The director is called {Name}, {Surname}. He was born in {YearBorn} at {Country}." +
                          $" He {(IsAlive ? "is alive" : "passed away")}";



    public Director(string name, string surname, int yearBorn, string country)
    {
        this.Name = name;
        this.Surname = surname;
        this.YearBorn = yearBorn;
        this.Country = country;
    }

    public Director() { }
}
