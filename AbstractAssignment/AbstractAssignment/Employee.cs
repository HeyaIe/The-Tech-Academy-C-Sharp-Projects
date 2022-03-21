using System;

namespace AbstractAssignment
{
    public class Employee : Person
    {
        public override void sayName()
        {
            Console.WriteLine("{0} {1}", firstName, lastName);
        }
    }
}
