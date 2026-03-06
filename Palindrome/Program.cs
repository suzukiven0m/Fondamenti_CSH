namespace Palindrome;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = [1, 2, 3, 2, 1];
        InvertiArray(array);
        StampaArray(array);
        Console.WriteLine(IsPalindromo(array)); 
    }

    static void InvertiArray(int[] array)  // ← removed "int"
    {
        Array.Reverse(array);
    }

    static void StampaArray(int[] array)   // ← removed "int"
    {
        string result = string.Join(" ", array);
        Console.WriteLine(result);
    }

    static bool IsPalindromo(int[] array)
    {
        int[] reversed = (int[])array.Clone();
        Array.Reverse(reversed);
        return array.SequenceEqual(reversed);
    }
}
