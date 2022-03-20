using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParam
{
    class Operation
    {
        public void operation1(out int num1, out int num2)
        {
            num1 = 15;
            num2 = num1 - 5;
            Console.WriteLine("Result: " + num2);
        }
    }
}
