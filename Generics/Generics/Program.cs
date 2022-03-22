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

            // Instantiate employee object
            Employee<string> em1 = new Employee<string>();
            em1.things = new List<string>() { "screws", "powerdrill", "workbench", "tracksaw", "marker" };

            Employee<int> em2 = new Employee<int>();
            em2.things = new List<int>() { 1, 10, 23, 21, 16, 4 };

            // Display list
            Console.WriteLine("\nEmployee 1");
            Console.WriteLine("-------------------------------------------");
            em1.listItems();

            Console.WriteLine("\nEmployee 2");
            Console.WriteLine("-------------------------------------------");
            em2.listItems();

            Console.Read();
        }
    }
}
