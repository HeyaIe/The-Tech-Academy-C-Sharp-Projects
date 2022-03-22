using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Enums");

            // Prompt user to enter current day
            Console.WriteLine("\nPlease enter the current day of the week.");

            try
            {
                // Parse input as type (DaysOfTheWeek), assign it to day
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
                Console.WriteLine(day);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            finally
            {
                Console.ReadLine();
            }
        }
        public enum DaysOfTheWeek
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
    }
}
