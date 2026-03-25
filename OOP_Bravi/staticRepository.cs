namespace OOP_Bravi;

internal class StaticRepository
{
    private static Studente[] _studenti =
    [
        new Studente("Geoffrey", "Agwasim", 2006, "non bravo"),
        new Studente("Simone", "Restivo", 2004, "non bravo"),
        new Studente("Robert", "Benchea", 2006, "bravo"),
        new Studente("Simone", "Demonte", 1990, "non bravo"),
        // new Studente("Davide", "Giolitti", 2001, "bravo"),
        // new Studente("Luca", "Foglia", 1997, "non bravo"),
        new Studente("Tommaso", "Martorana", 2006, "non bravo"),
        new Studente("Gabriele", "Bellè", 2005, "non bravo"),
        new Studente("Fabio", "Cerundolo", 1994, "bravo"),
        new Studente("Elias", "Durand", 2005, "non bravo"),
        new Studente("Facundo", "Fanti", 1991, "bravo"),
        new Studente("Leonida", "Qemeqi", 1999, "non bravo"),
        new Studente("Stefano", "Spadaccini", 2002, "bravo"),
        new Studente("Mattia", "Frison", 2002, "bravo"),
        new Studente("Ibrahim", "Diallo", 1999, "non bravo"),
        new Studente("Mirko", "Di Vincenzo", 2006, "bravo"),
        new Studente("Sara", "Novara", 2005, "non bravo"),
        new Studente("Paul", "Potosi", 2000, "non bravo"),
        new Studente("Salomé", "Mbang", 2005, "non bravo"),
        new Studente("Alessia", "Coppola", 2005, "non bravo"),
        new Studente("Antonio", "Duch", 2004, "non bravo"),
        new Studente("Frédéric", "Madzou", 1998, "non bravo"),
        new Studente("Stefano", "Vanni", 1998, "non bravo"),
        new Studente("Moaud", "Bousta", 2003, "non bravo")
    ];
    
    public static List<Studente> StudentList() => [.._studenti];
}
