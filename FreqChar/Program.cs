using System;

namespace FreqChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci una stringa: ");
            string testo = Console.ReadLine();
            
            var (vocali, consonanti, spazi, altri) = ContaCaratteri(testo);
            
            Console.WriteLine($"\n=== ANALISI CARATTERI ===");
            Console.WriteLine($"Vocali: {vocali}");
            Console.WriteLine($"Consonanti: {consonanti}");
            Console.WriteLine($"Spazi: {spazi}");
            Console.WriteLine($"Altri caratteri: {altri}");
            Console.WriteLine($"Totale: {testo?.Length ?? 0}");
            
            char piuFrequente = TrovaCharPiuFrequente(testo);
            if (piuFrequente != '\0')
            {
                Console.WriteLine($"\nCarattere più frequente: '{piuFrequente}'");
            }
            else
            {
                Console.WriteLine("\nNessuna lettera trovata nella stringa.");
            }
        }

        static (int vocali, int consonanti, int spazi, int altri) ContaCaratteri(string testo)
        {
            int vocali = 0, consonanti = 0, spazi = 0, altri = 0;

            if (string.IsNullOrEmpty(testo))
                return (vocali, consonanti, spazi, altri);

            foreach (char c in testo)
            {
                if (char.IsWhiteSpace(c))
                {
                    spazi++;
                }
                else if (char.IsLetter(c))
                {
                    char lower = char.ToLower(c);
                    if ("aeiou".Contains(lower))
                    {
                        vocali++;
                    }
                    else
                    {
                        consonanti++;
                    }
                }
                else
                {
                    altri++;
                }
            }

            return (vocali, consonanti, spazi, altri);
        }

        static char TrovaCharPiuFrequente(string testo)
        {
            if (string.IsNullOrEmpty(testo))
                return '\0';
            
            int[] frequenze = new int[26];
            
            foreach (char c in testo)
            {
                if (char.IsLetter(c))
                {
                    char lower = char.ToLower(c);
                    if (lower >= 'a' && lower <= 'z')
                    {
                        frequenze[lower - 'a']++;
                    }
                }
            }
            
            int maxFreq = -1;
            int indiceMax = -1;

            for (int i = 0; i < 26; i++)
            {
                if (frequenze[i] > maxFreq)
                {
                    maxFreq = frequenze[i];
                    indiceMax = i;
                }
            }
            
            if (maxFreq <= 0)
                return '\0';
            
            return (char)('a' + indiceMax);
        }
    }
}