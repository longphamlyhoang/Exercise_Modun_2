using System;

namespace Animal_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];
            animals[0] = new Tiger();
            animals[1] = new Chicken();
            animals[2] = new Dog();
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
            }

            Fruit[] fruits = new Fruit[2];
            fruits[0] = new Orange();
            fruits[1] = new Apple();
            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit.HowToEat());
            }
        }
    }
}
