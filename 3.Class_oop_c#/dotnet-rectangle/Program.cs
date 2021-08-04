using System;
namespace dotnet_rectangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the width: ");
            double width = Double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            double height = Double.Parse(Console.ReadLine());
            Ractangle ractangle = new Ractangle(width,height);
            Console.WriteLine(ractangle.Display());
            Console.WriteLine(ractangle.GetArea());
            Console.WriteLine(ractangle.GetPerimeter());
        }
    }
    public class Ractangle
    {
        double width;
        double height;
        public Ractangle()
        {

        }
        public Ractangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double GetArea()
        {
            return this.width * this.height;
        }
        public double GetPerimeter()
        {
            return (this.width+ this.height)*2;
        }
        public string Display()
        {
            return $"Ractangle: 'width ' {width}, 'height ' {height}";
        }
    }

}