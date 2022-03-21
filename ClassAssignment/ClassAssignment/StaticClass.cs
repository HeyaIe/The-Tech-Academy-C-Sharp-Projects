using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public static class StaticClass
    {
        public static void op(out int num1, out int num2)
        {
            Console.WriteLine("Please enter a number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = " + (num1 + num2), num1, num2);

        }

        // Overloading static method
        public static void op(out int num1)
        {
            Console.WriteLine("Please enter a number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} * 3 = " + (num1 * 3), num1);
        }
    }
}
