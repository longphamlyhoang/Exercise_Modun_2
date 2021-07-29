﻿using System;

namespace GreatesCommonFactor_jame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0 || b == 0)
            {
                Console.WriteLine("No greatest common factor");
            }
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            Console.WriteLine("Greatest common factor: " + a);
        }
    }
}
