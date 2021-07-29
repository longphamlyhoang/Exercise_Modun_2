using System;

namespace LinearEquationResolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Giver a equation as 'a*x+b=0',please enter constant: ");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0)
            {
                double solution = -b/a;
                Console.WriteLine($"The solution is: {solution}");
            } else {
                if (b==0)
                {
                    Console.Write("The solution is all x!");
                } else {
                    Console.Write("Nod solution!");
                }
            }
        }
    }
}
