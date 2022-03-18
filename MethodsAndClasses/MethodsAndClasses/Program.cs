using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Class & Methods");

            // Creating an object of class Math
            Math a = new Math();

            // Prompt user for a number to do math on
            Console.WriteLine("Please enter a number to do math on:");
            int num = Convert.ToInt32(Console.ReadLine());

            // Ask what math operation the user would like to
            Console.WriteLine("Which math operation would you like to do on " + num + "?");

            // List what each method does
            Console.WriteLine("----------------------------------------------------");
            // Method 1
            Console.WriteLine("\nEnter \"s\" to subtract number by 13");
            // Method 2
            Console.WriteLine("\nEnter \"a\" to add number by 13");
            // Method 3
            Console.WriteLine("\nEnter \"m\" to multiply number by 13");
            // Method 4
            Console.WriteLine("\nEnter \"d\" to divide number by 13\n");

            string response = Console.ReadLine();

            // Perform math depending on response
            if(response == "s")
            {
                Console.WriteLine(a.subtractBy13(num));
            }
            else if(response == "a")
            {
                Console.WriteLine(a.addBy13(num));
            }
            else if(response == "m")
            {
                Console.WriteLine(a.multiplyBy13(num));
            }
            else if(response == "d")
            {
                Console.WriteLine(a.divideBy13(num));
            }
            Console.Read();
        }
    }
}
