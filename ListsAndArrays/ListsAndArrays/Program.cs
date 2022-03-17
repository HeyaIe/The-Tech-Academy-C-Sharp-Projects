using System;
using System.Collections.Generic;

namespace ListsAndArrays
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Array of strings");

            // Array initialization
            string[] strArray = { "Keep", "it", "up", "you", "can", "do", "it" };

            // Flag
            bool isAppropriate = false;

            while (!isAppropriate)
            {
                // Prompt user for index input
                Console.WriteLine("Please select an index from 0-6 to display a string from an array.");
                int index = Convert.ToInt32(Console.ReadLine());

                if (index < 0 || index > 6)
                {
                    // Message clarification
                    Console.WriteLine("Please enter a value from 0-6.");
                }
                else
                {
                    // Display array at index
                    Console.WriteLine("Result: " + strArray[index]);
                    // Update flag
                    isAppropriate = true;
                }

            }

            // Array of integers
            Console.WriteLine("\nArray of integers");

            // Array initialization
            int[] intArray = { 5, 2, 10, 6, 2, 13, 40 };

            // Prompt user to pick an index
            Console.WriteLine("Please enter a number from 0-6 to display a number in the array.");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0 && num < 7)
            {
                // Display number in the array
                Console.WriteLine("Result: " + intArray[num]);
            }
            else
            {
                Console.WriteLine("Only enter a number from 0-6.");
            }

            // List
            Console.WriteLine("\nList of strings");

            List<string> strList = new List<string>();
            strList.Add("Hello");
            strList.Add("World!");

            // Prompt user to select an index from the list
            Console.WriteLine("Please enter a number from 0-1 to display a string from the list.");
            string pos = Console.ReadLine();
            try
            {
                int posList = Convert.ToInt32(pos);
                Console.WriteLine("Result: " + strList[posList]);
            }
            catch
            {
                Console.WriteLine("Please pick a numeral from 0-1.");
                int posList = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Result: " + strList[posList]);
            }


            Console.ReadLine();
        }
    }
}
