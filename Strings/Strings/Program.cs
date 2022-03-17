using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            string message = " is turning ";
            string name = "Heyale";
            int turningAge = 7;

            Console.WriteLine(name.ToUpper() + message + turningAge.ToString() + ".");

            // Stringbuilder
            StringBuilder str = new StringBuilder();
            str.Append("My name is Bryan");
            str.Append(", I am turning");
            str.Append(" 28.");

            Console.WriteLine(str);


            Console.ReadLine();
        }
    }
}
