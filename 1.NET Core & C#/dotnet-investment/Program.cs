using System;

namespace dotnet_investment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money;
            int month;
            double intersetRate ;
            Console.Write("Enter investment amount: ");
            money = Double.Parse(Console.ReadLine());
            Console.Write("Enter number of months: ");
            month = Int32.Parse(Console.ReadLine());
            Console.Write("Enter annual interest rate in percentage: ");
            intersetRate = Double.Parse(Console.ReadLine());
            double totalInterset = 0;
            for (int i = 1; i < month; i++)
            {
                totalInterset =  money *(intersetRate/100)/12*month;
            }
            Console.WriteLine("Total of interset: "+ totalInterset);
        }
    }
}
