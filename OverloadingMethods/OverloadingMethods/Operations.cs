using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods
{
    public class Operations
    {
        public int operation(int num1, int num2)
        {
            return num1 * num2;
        }
        public decimal operation(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
        public int operation(string num1, string num2)
        {
            int numb1 = Convert.ToInt32(num1);
            int numb2 = Convert.ToInt32(num2);

            return numb1 + numb2;
        }
    }
}
