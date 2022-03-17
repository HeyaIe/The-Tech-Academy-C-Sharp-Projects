using System;


namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            // While loop
            Console.WriteLine("While loop");

            bool isOldEnough = false;

            while (!isOldEnough)
            {
                Console.WriteLine("Please enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());

                if(age < 18)
                {
                    Console.WriteLine("Sorry, you must be at least 18 to join this community.");
                }
                else
                {
                    isOldEnough = true;
                    Console.WriteLine("Welcome!");
                }
            }

            // Do while loop
            Console.WriteLine("Do while loop");

            string response;

            do
            {
                Console.WriteLine("Are you over 18?");
                response = Console.ReadLine();

                switch (response)
                {
                    case "yes":
                    case "Yes":
                        Console.WriteLine("You are old enough.");
                        break;
                    case "no":
                    case "No":
                        Console.WriteLine("You are too young.");
                        break;
                    default:
                        Console.WriteLine("Please enter \"yes\" or \"no\".");
                        break;
                }
            }
            while (response == "no" || response == "No");


            Console.ReadLine();
        }
    }
}
