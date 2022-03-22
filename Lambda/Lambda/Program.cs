using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main()
        {
            // Introduction
            Console.WriteLine("Lambda");
            Console.WriteLine("-----------------------------\n");

            // Instantiate a list of employee data type
            List<Employee> emList = new List<Employee>();

            // Intantiate 10 employee objects
            emList.Add(new Employee() { fName = "Bryan", lName = "Ng", Id = 1 });
            emList.Add(new Employee() { fName = "Joe", lName = "Smith", Id = 2 });
            emList.Add(new Employee() { fName = "William", lName = "Williams", Id = 3 });
            emList.Add(new Employee() { fName = "Tia", lName = "Larer", Id = 4 });
            emList.Add(new Employee() { fName = "Sam", lName = "Adler", Id = 5 });
            emList.Add(new Employee() { fName = "Joe", lName = "Hayes", Id = 6 });
            emList.Add(new Employee() { fName = "Tom", lName = "Ford", Id = 7 });
            emList.Add(new Employee() { fName = "Joe", lName = "Ledger", Id = 8 });
            emList.Add(new Employee() { fName = "Brea", lName = "Marley", Id = 9 });
            emList.Add(new Employee() { fName = "Debbie", lName = "Keller", Id = 10 });

            // Instantiate a new list
            List<Employee> newEmList = new List<Employee>();

            // Create a foreach loop that adds employees with the fName 'Joe' to the new list
            foreach(Employee em in emList)
            {
                if(em.fName == "Joe")
                {
                    newEmList.Add(em);
                }
            }

            // Initialize a new list with condition using a lambda expression
            List<Employee> newEmList1 = emList.Where(x => x.fName == "Joe").ToList();

            foreach(Employee em in newEmList1)
            {
                Console.WriteLine("{0} {1}", em.fName, em.lName);
            }

            Console.Read();
        }
    }
}
