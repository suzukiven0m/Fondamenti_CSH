using System.Runtime.ConstrainedExecution;

namespace IMC
{
    internal class Program


    

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please insert your weight (in kg)");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, please insert your height (in meters)");
            int height = Convert.ToInt32(Console.ReadLine());
            int imc = weight / (height * height);
            Console.WriteLine($"Your IMC is: {imc} ");

            if (imc < 18.5)
            {

                Console.WriteLine("You are underweight");

            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("You are normal weight");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("You are overweight");
            }
            else if (imc >= 30)
            {
                Console.WriteLine("You are obese");
            }
        }
    }
}