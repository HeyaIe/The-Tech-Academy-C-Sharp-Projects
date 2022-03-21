using System;

namespace AbstractAssignment
{
    public class Employee : Person, IQuittable
    {
        public override void sayName()
        {
            Console.WriteLine("{0} {1}", firstName, lastName);
        }
        // Implement interface method
        public void Quit()
        {
            Console.WriteLine("\n{0} {1}'s resignation period has begun.", firstName, lastName);
        }
    }
}
