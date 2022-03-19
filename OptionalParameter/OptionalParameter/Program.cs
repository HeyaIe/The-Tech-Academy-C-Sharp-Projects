using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameter
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Optional Parameter");
            // Instantiating object of class
            Operations a = new Operations();

            // Prompt user to enter two numbers
            Console.WriteLine("Please enter a number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Optional - enter a second number to multiply them together:");
            // Try converting input2 to int and display solution
            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} * {1} = " + a.operation(num1, num2), num1, num2);
            }
            catch
            {
                Console.WriteLine("{0} * 1 = " + a.operation(num1), num1);
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
