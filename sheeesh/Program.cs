using System;

namespace TestMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            string program = "1";

            while (program == "1")
            {


                Console.WriteLine("\n1. Omvandla från Celsius till Fahrenheit");
                Console.WriteLine("2. Omvandla från Fahrenheit till Celsius");
                Console.WriteLine("3. Avsluta program\n");

                string grader = Console.ReadLine();

                switch (grader)
                {
                    case "1":
                        Console.WriteLine("Hur många grader Celsius vill du omvandla till Fahrenheit?");
                        double C = int.Parse(Console.ReadLine());
                        Console.WriteLine($"\n{C} grader Celsius blir {CelsiusToFahrenheit(C)} grader Fahrenheit\n");
                        Thread.Sleep(1000);
                        break;

                    case "2":
                        Console.WriteLine("Hur många grader Fahrenheit vill du omvandla till Celsius?");
                        double F = int.Parse(Console.ReadLine());
                        Console.WriteLine($"\n{F} grader Fahrenheit blir {FahrenheitToCelsius(F)} grader Celsius\n");
                        Thread.Sleep(1000);
                        break;

                    case "3":
                        program = Sluta("0");
                        break;

                    default:
                        Console.WriteLine("Skriv siffran 1 eller 2\n");
                        break;
                }
            }
        }

        static double CelsiusToFahrenheit(double C)
        {
            return 32 + C * 1.8;
        }

        static double FahrenheitToCelsius(double F)
        {
            return (F - 32) / 1.8;
        }

        static string Sluta(string stopp)
        {
            return stopp;
        }
    }
}