using System;

namespace dotnet_array_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[4]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[5]);
            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total+=array[i];
            }
            Console.WriteLine(total.ToString());
        }
    }
}
