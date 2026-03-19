using System;
using System.Collections.Generic;
using System.Linq;

namespace RubricaTelefono;

class Program
{
    static void Main(string[] args)
    {
        List<string> nomi = new List<string>();
        List<string> numeri = new List<string>();
        int choice;
        
        do
        {
            Console.WriteLine("\n--- RUBRICA TELEFONICA ---");
            Console.WriteLine("1. Insert a contact (Aggiungi)");
            Console.WriteLine("2. Search for a contact (Cerca)");
            Console.WriteLine("3. Eliminate a contact (Elimina)");
            Console.WriteLine("4. Show all contacts (Mostra tutti)");
            Console.WriteLine("5. How many contacts? (Conta)");
            Console.WriteLine("0. Exit");
            Console.Write("Choice: ");
            choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1: 
                    AggiungiContatto(nomi, numeri);
                    break;
                case 2: 
                    RicercaContatto(nomi, numeri);
                    break;
                case 3: 
                    EliminaContatto(nomi, numeri);
                    break;
                case 4: 
                    MostraTutti(nomi, numeri);
                    break;
                case 5: 
                    int count = ContaContatti(nomi);
                    Console.WriteLine($"Total contacts: {count}");
                    break;
                case 0:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
            
        } while (choice != 0);
    }

    static void AggiungiContatto(List<string> nomi, List<string> numeri)
    {
        Console.Write("Enter name: ");
        string nome = Console.ReadLine();
        
        Console.Write("Enter phone number: ");
        string numero = Console.ReadLine();
        
        if (!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(numero))
        {
            nomi.Add(nome);
            numeri.Add(numero);
            Console.WriteLine("Contact added successfully!");
        }
        else
        {
            Console.WriteLine("Invalid input! Both fields required.");
        }
    }

    static void RicercaContatto(List<string> nomi, List<string> numeri)
    {
        Console.Write("Enter name to search: ");
        string nome = Console.ReadLine();
        
        int index = nomi.IndexOf(nome);
        
        if (index != -1)
        {
            Console.WriteLine($"Found: {nomi[index]} - {numeri[index]}");
        }
        else
        {
            Console.WriteLine("Contact not found");
        }
    }

    static void EliminaContatto(List<string> nomi, List<string> numeri)
    {
        Console.Write("Enter name to delete: ");
        string nome = Console.ReadLine();
        
        int index = nomi.IndexOf(nome);
        
        if (index != -1)
        {
            nomi.RemoveAt(index);
            numeri.RemoveAt(index);
            Console.WriteLine("Contact deleted successfully!");
        }
        else
        {
            Console.WriteLine("Contact not found ");
        }
    }

    static void MostraTutti(List<string> nomi, List<string> numeri)
    {
        if (nomi.Count == 0)
        {
            Console.WriteLine("Phonebook is empty.");
            return;
        }

        // Create list of indices and sort by name
        var indices = Enumerable.Range(0, nomi.Count).ToList();
        indices.Sort((a, b) => string.Compare(nomi[a], nomi[b], StringComparison.OrdinalIgnoreCase));
        
        Console.WriteLine("\n--- CONTACT LIST (sorted) ---");
        foreach (int i in indices)
        {
            Console.WriteLine($"{nomi[i]} - {numeri[i]}");
        }
        Console.WriteLine("----------------------------");
    }

    static int ContaContatti(List<string> nomi)
    {
        return nomi.Count;
    }
}