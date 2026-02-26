namespace Presentazione_Personale
{
    internal class Program
    {


        static void Main(string[] args)
        {

            MyData();



        }
        static void MyData()
        {
            string name = "Facundo";
            int age = 34;
            string city = "Buenos Aires";

            Console.WriteLine($"My name is {name}, i have {age} and i live in {city}");


        }
    }
}