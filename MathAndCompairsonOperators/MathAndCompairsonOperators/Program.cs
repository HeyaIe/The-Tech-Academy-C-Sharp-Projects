using System;

namespace MathAndCompairsonOperators
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Anonymous Income Comparison Program");
            // Person 1 weekly salary
            Console.WriteLine("Person 1");
            // Rate
            Console.WriteLine("What is your hourly rate?");
            string rate1 = Console.ReadLine();
            // Convert to double
            double person1Rate = Convert.ToDouble(rate1);
            // Hours
            Console.WriteLine("How many hours did you work this week?");
            string hours1 = Console.ReadLine();
            // Convert hours to int
            int person1Hours = Convert.ToInt32(hours1);

            // Person 2 weekly salary
            Console.WriteLine("Person 2");
            // Rate
            Console.WriteLine("What is your hourly rate?");
            string rate2 = Console.ReadLine();
            // Convert to double
            double person2Rate = Convert.ToDouble(rate2);
            // Hours
            Console.WriteLine("How many hours did you work this week?");
            string hours2 = Console.ReadLine();
            // Convert hours to int
            int person2Hours = Convert.ToInt32(hours2);

            // Display the annual salary of Person 1
            Console.WriteLine("Annual salary of Person 1");
            double salary1 = person1Rate * person1Hours;
            salary1 *= 52;
            Console.WriteLine(salary1);

            // Display the annual salary of Person 2
            Console.WriteLine("Annual salary of Person 2");
            double salary2 = person2Rate * person2Hours;
            salary2 *= 52;
            Console.WriteLine(salary2);

            // Display true or false comparing which person makes more anually
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isMore = salary1 > salary2;
            Console.WriteLine(isMore);

            Console.ReadLine();
        }
    }
}
