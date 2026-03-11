namespace OOP_Film;

internal class Film
{
    public string Title { get; set; } = "";
    public int Year { get; set; }

    public string Info => $"The film  is called {Title}. It was made in {Year}.";

    // public Film(string title, int year)
    // {
        // this.Title = title;
        // this.Year = year;
    // }
    public Film(){ }


}