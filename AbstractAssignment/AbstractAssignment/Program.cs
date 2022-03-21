using System;

namespace AbstractAssignment
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Abstract class and methods\n");

            // Instantiate employee object
            Employee em = new Employee() { firstName = "Sample", lastName = "Student" };

            // Call overridden method
            em.sayName();

            // Using polymorphism to create an object
            IQuittable em1 = new Employee() { firstName = "Sam", lastName = "Stu" };
            em1.Quit();

            Console.Read();
        }
    }
}
