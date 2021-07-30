using System;

namespace dotnet_change_temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("0. Exit ");
            Console.Write("Enter your choice: ");
            int choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Enter fahrenheit: ");
                    float fahrenheit = float.Parse(Console.ReadLine());
                    Console.WriteLine("Fahrenheit to Celsius " + f(fahrenheit));
                    break;
                case 2:
                    Console.WriteLine("Enter celsius: ");
                    float celsius = float.Parse(Console.ReadLine());
                    Console.WriteLine(" Celsius to Fahrenheit " + c(celsius));
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("khong co chuc nang");
                    break;
            }
        }
        static float c(float celsius)
        {
            float fahrenheit = (9 * celsius) / 5 - 32;
            return fahrenheit;
        }
        static float f(float fahrenheit)
        {
            float celsius = (5 / 9) * (fahrenheit - 32);
            return celsius;
        }
    }
}
