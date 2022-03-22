using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Generics");

            // Instantiate employee objects
            Employee<string> em1 = new Employee<string>();
            em1.things = new List<string>() { "screws", "powerdrill", "tracksaw", "workbench", "marker" };

            Employee<int> em2 = new Employee<int>();
            em2.things = new List<int>() { 1, 3, 10, 20, 23, 15, 4 };

            // Display items
            Console.WriteLine("\nEmployee 1");
            Console.WriteLine("-------------------------------");
            em1.listItems();

            Console.WriteLine("\nEmployee 2");
            Console.WriteLine("-------------------------------");
            em2.listItems();

            Console.Read();
        }
    }
}
