using System;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Class Inheritance\n");

            // Instantiate + initalize employee object
            Employee emp = new Employee() { FirstName = "Sample", LastName = "Student" };
            // Call super method
            emp.SayName();

            Console.Read();
        }
    }
}
