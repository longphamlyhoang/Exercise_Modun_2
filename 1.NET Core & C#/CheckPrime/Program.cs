using System;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a numbber: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number<2)
            {
                Console.WriteLine(number+" is a not prime");
            } else
            {
                int i = 2;
                bool check = true;
                while (i<= Math.Sqrt(number))
                {
                    if (number%i==0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    Console.WriteLine(number+" is a prime");
                } else
                {
                    Console.WriteLine(number+ " not is a prime");
                }
            }
        }
    }
}
