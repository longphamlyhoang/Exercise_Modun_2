using System;

namespace dotnet_FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.WriteLine("nhap size");
                size = Int32.Parse(Console.ReadLine());
                if (size>20)
                {
                    Console.WriteLine("nhap lai size:");
                }
            } while (size>20);

            array = new int[size];
            int i = 0;
            while (i<array.Length)
            {
                Console.WriteLine("phan tu cua mang "+ (i+1)+" :");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }

            Console.WriteLine("danh sach phan tu: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }

            int max = array[0];
            int index = 1;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j]>max)
                {
                    max = array[j];
                    index = j+1;
                }
            }
            Console.WriteLine("gia tri lon nhat trong mang la "+max+" o vi tri "+index);
        }
    }
}
