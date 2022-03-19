using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Overloading Methods");
            Console.WriteLine("--------------------------------------------");

            // Create an object of class
            Operations a = new Operations();

            // Prompt user for two numbers
            Console.WriteLine("Please enter a number:");
            string input1 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1);
            Console.WriteLine("Please enter a second number:");
            string input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2);

            // Display result
            Console.WriteLine("{0} * {1} = " + a.operation(num1, num2), num1, num2);

            // Overloading operation method with decimal arguments
            Console.WriteLine("15.2 / 13.1 = " + a.operation(15.2m, 13.1m));

            // Overloading operation method with string arguments
            Console.WriteLine("105 + 206 = " + a.operation("105", "206"));

            Console.Read();
        }
    }
}
