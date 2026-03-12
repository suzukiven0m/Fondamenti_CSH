namespace OOP_Rectangle;

class Program
{
    static void Main(string[] args)
    {
        Rectangle[] rectangles =
        [
            new Rectangle(10, 40),
            new Rectangle(4, 4),
            new Rectangle(8, 15)

        ];
        foreach (var r in rectangles)
        {
            Console.WriteLine(r);
        }


    }
}
