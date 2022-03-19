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


            // Display result
            Console.WriteLine("10 * 3 = " + a.operation(10, 3));

            // Overloading operation method with decimal arguments
            Console.WriteLine("15.2 / 13.1 = " + a.operation(15.2m, 13.1m));

            // Overloading operation method with string arguments
            Console.WriteLine("105 + 206 = " + a.operation("105", "206"));

            Console.Read();
        }
    }
}
