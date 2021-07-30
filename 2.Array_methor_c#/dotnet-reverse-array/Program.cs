using System;

namespace dotnet_reverse_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.Write("Nhap size: ");
                size = int.Parse(Console.ReadLine());
                if (size>20)
                {
                    Console.WriteLine("Size khong qua 20 phan tu");
                }
            } while (size>20);

            array = new int[size];
            int i = 0;
            while (i<array.Length)
            {
                Console.Write("nhap phan tu cua mang "+ (i+1)+": ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }

            Console.WriteLine("cac phan tu trong mang: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }

            for (int j = 0; j < array.Length/2; j++)
            {
                int temp = array[j];
                array[j] = array[size-1-j];
                array[size-1-j] = temp;
            }

            Console.WriteLine("Reverse array: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]+ "\t");
            }
        }
    }
}
