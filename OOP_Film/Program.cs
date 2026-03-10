namespace OOP_Film;

class Program
{
    static void Main(string[] args)
    {
        
        Actor actor = new Actor();
        actor.Name = "Leonardo";
        actor.Surname = "Di Caprio";
        
        Director director = new Director();
        director.Name = "Alejandro";
        director.Surname = "Innaritu";
        director.Country = "Mexico";
        director.YearBorn = 1963;
        
        Film film = new Film();
        film.Title = "The Revenenant";
        film.Year = 2015;
        
        Location location = new Location();
        location.Name = "Ushuaia";
        
        Nation nation = new Nation();
        nation.Name = "Argentina";
        
        Console.WriteLine(film.Info());
        Console.WriteLine(director.Info());
        Console.WriteLine(actor.Info());
        Console.WriteLine(nation.Info());
        Console.WriteLine(location.Info());
        
        
        





    }
}