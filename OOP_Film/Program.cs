namespace OOP_Film;

class Program
{
    static void Main(string[] args)
    {
        // 1. Empty constructor
        Director director1 = new();
        director1.Name = "Steven";
        director1.Surname = "Spielberg";
        director1.YearBorn = 1946;
        director1.Country = "USA";

        // 2. Object initializer
        Director director2 = new()
        {
            Name = "Christopher",
            Surname = "Nolan",
            YearBorn = 1970,
            Country = "UK"
        };

        // 3. All parameters
        Director director3 = new("Alejandro", "Iñárritu", 1963, "Mexico");

        
        Console.WriteLine(director1.Info);
        Console.WriteLine(director2.Info);
        Console.WriteLine(director3.Info);
    }
}
