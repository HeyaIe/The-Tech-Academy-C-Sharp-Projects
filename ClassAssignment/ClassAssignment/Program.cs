using System;

namespace ClassAssignment
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Class Submission Assignment");

            // Instantiate an object
            Operations a = new Operations();

            // Prompt user for a number
            Console.WriteLine("Please enter a number:");
            // Call method, passing in user input
            a.operation(Convert.ToInt32(Console.ReadLine()));

            // Declare a varaible
            int num;
            // Call method, passing in an out parameter
            a.operation1(out num);

            // Declare variables
            int num1;
            string text;
            // Call overloading methods, passing in out parameters
            a.operation(out num1, out text);

            // Declare variables
            int num3, num4, num5;

            // Calling a static method from a static class
            StaticClass.op(out num3, out num4);

            // Calling overloading static method
            StaticClass.op(out num5);

            Console.Read();
        }
    }
}
