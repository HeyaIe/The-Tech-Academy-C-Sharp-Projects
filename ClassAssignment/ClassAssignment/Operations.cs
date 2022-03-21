using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    public class Operations
    {
        public void operation(int num)
        {
            num /= 2;
            Console.WriteLine("{0} / 2 = " + num, num);
        }

        // Method with output parameters
        public void operation1(out int num)
        {
            num = 5;
            num *= 2;
            Console.WriteLine("5 * 2 = " + num);
        }

        // Define an overloading method
        public void operation(out int num, out string text)
        {
            Console.WriteLine("Pick a number");
            num = Convert.ToInt32(Console.ReadLine());
            text = "You chose ";

            Console.WriteLine(text + num);
        }
    }
}
