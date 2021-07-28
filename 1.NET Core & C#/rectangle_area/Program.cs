using System;

namespace rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            float width;
            float height;
            Console.Write("Enter is width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter is height: ");
            height = float.Parse(Console.ReadLine());
            float area = width*height;
            Console.Write("area is : "+ area);
        }
    }
}
