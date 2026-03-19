namespace OOP_Library;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA DI GESTIONE BIBLIOTECA ===\n");

        // Creazione della biblioteca
        Biblioteca biblioteca = new Biblioteca();

        // Creazione di 5+ libri
        Libro libro1 = new Libro("Il Signore degli Anelli", "J.R.R. Tolkien", "978-0544003415", 1954);
        Libro libro2 = new Libro("Harry Potter e la Pietra Filosofale", "J.K. Rowling", "978-0747532699", 1997);
        Libro libro3 = new Libro("1984", "George Orwell", "978-0451524935", 1949);
        Libro libro4 = new Libro("Il Piccolo Principe", "Antoine de Saint-Exupéry", "978-0156012195", 1943);
        Libro libro5 = new Libro("Don Chisciotte", "Miguel de Cervantes", "978-8424116530", 1605);
        Libro libro6 = new Libro("Lo Hobbit", "J.R.R. Tolkien", "978-0547928227", 1937);

        // Aggiunta libri al catalogo
        Console.WriteLine("--- Aggiunta libri al catalogo ---");
        biblioteca.AggiungiLibro(libro1);
        biblioteca.AggiungiLibro(libro2);
        biblioteca.AggiungiLibro(libro3);
        biblioteca.AggiungiLibro(libro4);
        biblioteca.AggiungiLibro(libro5);
        biblioteca.AggiungiLibro(libro6);
        Console.WriteLine();

        // Stampa catalogo iniziale
        biblioteca.StampaCatalogo();

        // Stampa statistiche iniziali
        biblioteca.StampaStatistiche();

        // Presta alcuni libri
        Console.WriteLine("--- Operazioni di prestito ---");
        libro1.Presta();  // Il Signore degli Anelli
        libro3.Presta();  // 1984
        libro5.Presta();  // Don Chisciotte
        libro1.Presta();  // Tentativo di prestare di nuovo lo stesso libro
        Console.WriteLine();

        // Stampa catalogo dopo i prestiti
        biblioteca.StampaCatalogo();

        // Stampa statistiche dopo i prestiti
        biblioteca.StampaStatistiche();

        // Test ricerca per titolo
        Console.WriteLine("--- Ricerca per titolo (contiene 'Harry') ---");
        var risultatiTitolo = biblioteca.CercaPerTitolo("Harry");
        foreach (var libro in risultatiTitolo)
        {
            Console.WriteLine(libro);
        }
        Console.WriteLine();

        // Test ricerca per autore
        Console.WriteLine("--- Ricerca per autore (contiene 'Tolkien') ---");
        var risultatiAutore = biblioteca.CercaPerAutore("Tolkien");
        foreach (var libro in risultatiAutore)
        {
            Console.WriteLine(libro);
        }
        Console.WriteLine();

        // Restituzione di un libro
        Console.WriteLine("--- Restituzione libro ---");
        libro3.Restituisci();  // Restituisci 1984
        libro3.Restituisci();  // Tentativo di restituire di nuovo
        Console.WriteLine();

        // Stampa finale
        Console.WriteLine("--- Stato finale ---");
        biblioteca.StampaCatalogo();
        biblioteca.StampaStatistiche();
    }
}
