using System;

namespace Class_Animal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("20kg","1m","hung");
            cat.PrintInfo();
            Dog dog = new Dog("nguyen","58kg","1.65m");
            dog.PrintInfo();
        }
    }
    public abstract class Animal
    {
        protected string width { get; set; }
        protected string height { get; set; }
        public Animal(string width, string height)
        {
            this.width = width;
            this.height = height;
        }
        public abstract void PrintInfo();
    }
    class Cat : Animal
    {
        private string Name { get; set; }
        public Cat(string width, string height, string name)
        : base(width, height)
        {
            this.Name = name;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"name: {this.Name} width: {this.width} height: {this.height}");
        }
    }
    class Dog : Animal
    {
        private string Name { get;set;}
        public Dog(string name, string width, string height)
        :base(width,height) 
        {
            this.Name = name;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"name: {this.Name} width: {this.width} hieght: {this.height}");
        }
    }

}
