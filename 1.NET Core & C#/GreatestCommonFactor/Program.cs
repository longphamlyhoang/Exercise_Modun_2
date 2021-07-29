using System;

namespace GreatestCommonFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int j;
            int ucln = 1;
            Console.Write("number 1: ");
            number1 = Int32.Parse(Console.ReadLine());
            Console.Write("number 2: ");
            number2 = Int32.Parse(Console.ReadLine());
            j = (number1 < number2) ? number2 : number1;
            for (int i = 1; i <= j; i++)
            {
                if (number1 % i == 0 && number2 % i == 0)
                {
                    ucln = i;
                }
            }
            Console.WriteLine(ucln);
        }
    }
}
