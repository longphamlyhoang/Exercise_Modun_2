﻿using System;

namespace dotnet_find_value_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = {"long","buu","nam","hung","thanh"};
            Console.Write("Enter a name is student: ");
            string input_name = Console.ReadLine();
            bool isExist = false;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].Equals(input_name))
                {
                    Console.WriteLine("Position of the students in the list "+ input_name + " is: "+ (i+1));
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                Console.WriteLine("Not found" + input_name + " in the list.");
            }

        }
    }
}
