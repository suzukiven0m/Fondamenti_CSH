namespace Rectangle
{
    internal class Program
    {
       
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
