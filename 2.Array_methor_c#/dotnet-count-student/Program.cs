using System;

namespace dotnet_count_student
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.Write("nhap so luong sinh sinh vien: ");
                size = Int32.Parse(Console.ReadLine());
                if (size > 30)
                {
                    Console.WriteLine("Size should not exceed 30");
                }
            } while (size > 30);

            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("nhap diem sinh vien " + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
            }

            int count = 0;
            Console.Write("danh sach diem sinh vien la: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j]);
                if (array[j]>=5 && array[j]<=10)
                {
                    count++;
                }

            }
            Console.Write(" \n so luong sinh vien do la: "+ count);

        }
    }
}
