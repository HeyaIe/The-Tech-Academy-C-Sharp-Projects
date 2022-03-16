using System;

namespace Branching
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Welcome to Package Express.\nPlease follow the instructions below.\n");

            // Prompt user for package weight
            Console.WriteLine("Enter package weight:");
            double packageWeight = Convert.ToDouble(Console.ReadLine());

            // Display message if package is too heavy
            if(packageWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                // Prompt user for package width
                Console.WriteLine("Enter package width:");
                double packageWidth = Convert.ToDouble(Console.ReadLine());

                // Prompt user for package height
                Console.WriteLine("Enter package height:");
                double packageHeight = Convert.ToDouble(Console.ReadLine());

                // Prompt user for package length
                Console.WriteLine("Enter package length:");
                double packageLength = Convert.ToDouble(Console.ReadLine());
                
                // Calculate the dimensions total
                if(packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package is too big to be shipped via Package Express.");
                }
                else
                {
                    // Quote
                    double quote = (packageWidth * packageHeight * packageLength) * packageWeight;
                    quote /= 100;
                    
                    // Display quote
                    Console.WriteLine("Your estimated total for shipping this package is: " + Math.Round(quote, 2));
                }
            }
            Console.ReadLine();
        }
    }
}
