using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("The Tech Academy.\nStudent Daily Report.");

            // Asks for user's name
            Console.WriteLine("\nWhat is your name?");
            string name = Console.ReadLine();
            
            // Asks for the name of the course
            Console.WriteLine("\nHello, " + name + "! What course are you on?");
            string courseName = Console.ReadLine();

            // Asks for the page number of the course
            Console.WriteLine("\nWhat page number are you on?");
            string pageNum = Console.ReadLine();
            // Converts pageNum to an integer
            int pageNum1 = Convert.ToInt32(pageNum);

            // Asks if the user needs any assistance
            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\".");
            string helpResponse = Console.ReadLine();
            //Converts string to a boolean
            bool isInNeedOfHelp = Convert.ToBoolean(helpResponse);

            // Asks if the user has any positive experiences they'd like to share
            Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            // Asks if the user has any other feedback they'd like to provide
            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // Asks the user how many hours were put into studying
            Console.WriteLine("\nHow many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            // Converts hoursStudied to an integer
            int hoursStudied1 = Convert.ToInt32(hoursStudied);

            // Print message to thank user
            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
