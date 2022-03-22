using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Employee<T> : Person
    {
        public int Id { get; set; }
        public List<T> things { get; set; }

        public void listItems()
        {
            foreach(var i in things)
            {
                Console.WriteLine(i);
            }
        }
    }
}
