using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Exception Handling");

            // Initalize a list of integers
            List<int> intList = new List<int>() { 13, 15, 6, 2, 20, 39, 41 };

            // Prompt user for a number to divide by
            Console.WriteLine("Please enter a number to divide each number in the list by:");
            string input = Console.ReadLine();

            // Separator
            Console.WriteLine("\n---------------------Results----------------------");

            // Try dividing user's input
            try
            {
                int input1 = Convert.ToInt32(input);

                // Divide each element in the list by user's input
                foreach (int num in intList)
                {

                    Console.WriteLine(num / input1);
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Please enter only numbers.");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("0 cannot be divided.");
            }
            finally
            {
                Console.WriteLine("\nPassed the try/catch block.");
                Console.Read();
            }
        }
    }
}
