namespace Temperature_While
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature?: ");
            var temperature = Convert.ToInt32(Console.ReadLine());
            switch (temperature)
            {
                case < 0:
                    Console.WriteLine("Its Really Cold!");
                    break;
                case > 0 and < 15:
                    Console.WriteLine("Its Cold!");
                    break;
                case > 15 and < 25:
                    Console.WriteLine("Mild");
                    break;
                default:
                    Console.WriteLine("Its Hot!");
                    break;
            }
        }

    }
}