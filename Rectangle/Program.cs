namespace Rectangle
{
    internal class Program
    {
        //        Dichiara due variabili double: base e altezza.Assegna dei valori a tua scelta.Calcola l'area
        //(base × altezza) e il perimetro(2 × (base + altezza)). Stampa i risultati con 2 cifre decimali.
        static void Main(string[] args)
        {
            AreaRectangle();
            PerimetreRectangle();
        }

        static void AreaRectangle()
        {
            double b = 10;
            double a = 40;
            double area = b * a;
            Console.WriteLine(area);




        }
        static void PerimetreRectangle()
        {
            double b = 10;
            double a = 40;
            double perimetre = 2 * (b + a);
            Console.WriteLine(perimetre);




        }
    }
}
