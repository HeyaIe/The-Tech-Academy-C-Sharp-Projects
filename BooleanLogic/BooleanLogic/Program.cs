using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction
            Console.WriteLine("Boolean Logic");

            // Age
            Console.WriteLine("How old are you?");
            string strAge = Console.ReadLine();
            // Convert strAge to int
            int age = Convert.ToInt32(strAge);

            // DUI
            Console.WriteLine("Have you ever had a DUI? Please enter \"true\" or \"false\".");
            string DUI = Console.ReadLine();
            // Convert DUI to boolean
            bool isDUI = Convert.ToBoolean(DUI);

            // Speeding tickets
            Console.WriteLine("How many speeding tickets do you have?");
            string strTickets = Console.ReadLine();
            // Convert strTickets to int
            int tickets = Convert.ToInt32(strTickets);

            Console.WriteLine("Qualified?");

            // Qualification process
            Console.WriteLine(age > 15 && isDUI == false && tickets < 4);

            Console.ReadLine();
        }
    }
}
