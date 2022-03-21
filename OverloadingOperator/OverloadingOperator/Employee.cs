using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperator
{
    public class Employee : Person
    {
        public int Id { get; set; }

        public static bool operator==(Employee employee1, Employee employee2)
        {
            if(employee1.Id == employee2.Id)
            {
                Console.WriteLine("{0} and {1} are the same person.", employee1.firstName, employee2.firstName);
                return true;
            }
            else
            {
                Console.WriteLine("{0} and {1} are not the same person.", employee1.firstName, employee2.firstName);
                return false;
            }
        }
        public static bool operator!=(Employee employee1, Employee employee2)
        {
            if(employee1.Id != employee2.Id)
            {
                Console.WriteLine("{0} and {1} are not the same person.", employee1.firstName, employee2.firstName);
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
