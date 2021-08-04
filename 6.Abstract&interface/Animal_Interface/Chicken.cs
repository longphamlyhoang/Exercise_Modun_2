using System;
namespace Animal_Interface
{
    class Chicken : Animal, IEdible
    {
        public override String MakeSound()
        {
            return "chicken: cluck_cluck!";
        }
        public String HowToEat()
        {
            return "could be fried";
        }
    }
}