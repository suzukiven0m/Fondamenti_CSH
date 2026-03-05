namespace Array;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] voti = [18, 1, 22, 10, 26, 29, 30, 19, 20, 15];
        CalcolaMedia(voti);
        TrovaMassimo(voti);
        TrovaMinimo(voti);
        ContaPromossi(voti);
    }

    static void CalcolaMedia(int[] voti)
    {
        double media = (double)voti.Sum() / voti.Length;
        Console.WriteLine($"The average is {media}");
    }

    static void TrovaMassimo(int[] voti)
    {
        var max = voti.Max();
        Console.WriteLine($"The max is {max}");
    }

    static void TrovaMinimo(int[] voti)
    {
        var min = voti.Min();
        Console.WriteLine($"The min is {min}");
    }

    static void ContaPromossi(int[] voti)
    {
        var promossi = voti.Count(v => v >= 18);
        Console.WriteLine($"Promoted students: {promossi}");
    }
}