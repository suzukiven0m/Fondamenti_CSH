namespace GestioneSpesa;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        int choice;
        do
        {
            Console.WriteLine("1. Add a product.");
            Console.WriteLine("2. Remove article (by name)");
            Console.WriteLine("3. See list");
            Console.WriteLine("4. How many articles?");
            Console.WriteLine("0. Escape"); 
            
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: AddArticle(list);
                    break;
                case 2: RemoveArticle(list);
                    break;
                case 3: SeeList(list);
                    break;
                case 4: HowMany(list);
                    break;
            }
            
            
        } while (choice != 0);

        Console.WriteLine("Goodbye!!!");
    }

    static void AddArticle(List<string> list)
    {
        Console.WriteLine("Add a new article: ");
        list.Add(Console.ReadLine());
    }

    static void RemoveArticle(List<string> list)
    {
        Console.WriteLine("Write article to remove: ");
        string name = Console.ReadLine();
        if (list.Contains(name))
        {
            list.Remove(name);
        }
        else
        {
            Console.WriteLine("Not found!");
        }
            
    }
    static void SeeList(List<string> list)
    {
        if (list.Count == 0)
        {
            Console.WriteLine("List is empty!");
        }
        else
        {
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
        
    }

    static void HowMany(List<string> list)
    {
        Console.Clear();
        Console.WriteLine(list.Count == 0 ? "List is empty!" : $"There are  {list.Count} articles in list.");
    }
}