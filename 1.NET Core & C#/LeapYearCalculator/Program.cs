using System;

namespace LeapYearCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            bool isleapYear = false;
            Console.Write("Enter is year: ");
            year = Convert.ToInt32(Console.ReadLine());
            bool isDivisibleBy4 = year % 4 == 0;
            if (isDivisibleBy4)
            {
                bool isDivisibleBy100 = year % 100 == 0;
                if (isDivisibleBy100)
                {
                    bool isDivisibleBy400 = year % 400 == 0;
                    if (isDivisibleBy400)
                    {
                        isleapYear = true;
                    }
                }
                else
                {
                    isleapYear = true;
                }
            }
            if (isleapYear)
            {
                Console.WriteLine($"is a leap year {year}");
            } else
            {
                Console.WriteLine($"is not a leap year {year}");
            }
        }
    }
}
