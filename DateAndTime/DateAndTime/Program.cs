using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction
            Console.WriteLine("DateTime");
            // Display current date time.
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);

            // Prompt user for a number
            Console.WriteLine("Please enter a number:");

            // Display updated date time after adding hours
            Console.WriteLine(DateTime.Now.AddHours(Convert.ToDouble(Console.ReadLine())));

            Console.Read();
        }
    }
}
