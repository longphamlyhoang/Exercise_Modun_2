using System;

namespace bmi_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double width;
            double height;
            Console.WriteLine("please enter a width: ");
            width = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a height: ");
            height = Double.Parse(Console.ReadLine());
            double bmi = width / Math.Pow(height, 2);
            bmi = Math.Round(bmi, 1);
            if (bmi < 18.5)
            {
                Console.WriteLine("underweight");
            }
            else if (bmi < 25.0)
            {
                Console.WriteLine("normal");
            }
            else if (bmi < 30.0)
            {
                Console.WriteLine("overweight");
            } else {
                Console.WriteLine("obese");
            }
        }
    }
}
