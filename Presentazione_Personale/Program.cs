namespace Presentazione_Personale
{
    internal class Program
    {

        //        Dichiara tre variabili: nome(string), età(int) e città(string). Assegna i tuoi dati reali.Poi
        //stampa a video un messaggio del tipo: "Mi chiamo Luca, ho 22 anni e vivo a Milano."

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