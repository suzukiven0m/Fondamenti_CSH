namespace OOP_Bravi;

class Program
{
    static void Main(string[] args)
    {
        // Get students from static repository (as List)
        List<Studente> elencoStudenti = StaticRepository.StudentList();

        // Count bravi and non bravi 
        int contaBravi = 0;
        int contaNonBravi = 0;

        for (int i = 0; i < elencoStudenti.Count; i++)
        {
            if (elencoStudenti[i].Valutazione == "bravo")
                contaBravi++;
            else
                contaNonBravi++;
        }

        Console.WriteLine($"Total students: {elencoStudenti.Count}");
        Console.WriteLine($"Bravi: {contaBravi}, Non bravi: {contaNonBravi}");
        Console.WriteLine();

        // Create the two lists
        var bravi = new List<Studente>(contaBravi);
        var nonBravi = new List<Studente>(contaNonBravi);

        // Fill the two lists
        for (int i = 0; i < elencoStudenti.Count; i++)
        {
            if (elencoStudenti[i].Valutazione == "bravo")
            {
                bravi.Add(elencoStudenti[i]);
            }
            else
            {
                nonBravi.Add(elencoStudenti[i]);
            }
        }

        // Shuffle both lists (Fisher-Yates algorithm)
        ShuffleList(bravi);
        ShuffleList(nonBravi);

        // Print the pairs
        int numeroCoppie = Math.Min(bravi.Count, nonBravi.Count);

        Console.WriteLine($"Forming {numeroCoppie} pairs...");
        Console.WriteLine();

        for (int i = 0; i < numeroCoppie; i++)
        {
            Console.WriteLine(
                $"La coppia numero {i + 1} è " +
                $"{bravi[i].Cognome} {bravi[i].Nome} [bravo] e " +
                $"{nonBravi[i].Cognome} {nonBravi[i].Nome} [non bravo]"
            );
        }

        // Report any unmatched students
        if (bravi.Count > nonBravi.Count)
        {
            Console.WriteLine();
            Console.WriteLine($"Note: {bravi.Count - nonBravi.Count} 'bravo' student(s) could not be paired:");
            for (int i = numeroCoppie; i < bravi.Count; i++)
            {
                Console.WriteLine($"  - {bravi[i].Cognome} {bravi[i].Nome} [bravo]");
            }
        }
        else if (nonBravi.Count > bravi.Count)
        {
            Console.WriteLine();
            Console.WriteLine($"Note: {nonBravi.Count - bravi.Count} 'non bravo' student(s) could not be paired:");
            for (int i = numeroCoppie; i < nonBravi.Count; i++)
            {
                Console.WriteLine($"  - {nonBravi[i].Cognome} {nonBravi[i].Nome} [non bravo]");
            }
        }
    }

    // Fisher-Yates shuffle algorithm for List<T>
    static void ShuffleList(List<Studente> list)
    {
        Random random = new Random();
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            // Swap elements
            Studente temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
