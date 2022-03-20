using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParam
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Out Parameters");

            // Insantiate object from class
            Operation a = new Operation();

            // Initalize two variables
            int num1 = 0;
            int num2 = 0;

            // Call method passing in two out parameters
            a.operation1(out num1, out num2);

            Console.Read();
        }
    }
}
