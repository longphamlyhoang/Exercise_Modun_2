using System;

namespace Static_Property
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("long","v1");
            Console.WriteLine(Car.numberofcars);
            Car car2 = new Car("buu","v2");
            Console.WriteLine(Car.numberofcars);
            car1.Display();
            car2.Display();
        }
    }
    public class Car
    {
        private string Name;
        private string Engine;
        public static int numberofcars;
        public Car(string Name, string engine)
        {
            this.Name = Name;
            this.Engine = engine;
            numberofcars ++;
        }
        public void Display()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Engine);
        }
    }

}
