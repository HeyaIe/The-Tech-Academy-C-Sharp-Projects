using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperator
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Overloading Operator\n");

            // Instantiating two employee objects
            Employee person1 = new Employee() { firstName = "Bryan", Id = 13 };
            Employee person2 = new Employee() { firstName = "Sam", Id = 1 };

            // Calling overloaded == operator
            Console.WriteLine(person1 == person2);

            Console.Read();
        }
    }
}
