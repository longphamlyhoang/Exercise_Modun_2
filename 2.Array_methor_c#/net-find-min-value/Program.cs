using System;

namespace net_find_min_value
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] {15,4,7,4,8,5,3,8,9};
            int index = MinValue(array);
            Console.WriteLine("phan tu nho nhat trong mang la "+ array[index]);
        }

        public static int MinValue(int []array)
        {
            int min = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<min)
                {
                    min = array[i];
                    index = i;
                }
                
            }
            return index;
        }


    }
}
